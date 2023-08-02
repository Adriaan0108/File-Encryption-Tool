using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //Added
using System.IO;                    //Added

namespace CMPG215
{
    public partial class Form1 : Form
    {
        string ext;
        string[] filePaths;

        public Form1()
        {
            InitializeComponent();
        }

        //GenerateSalt
        public static byte[] GenSalt()
        {
            byte[] data = new byte[32];
            using (RNGCryptoServiceProvider rgnCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rgnCryptoServiceProvider.GetBytes(data);
            }
            return data;
        }

        //Encrypt Button
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" && Path.GetExtension(openFileDialog1.FileName) == ".aes")
            {
                MessageBox.Show("Invalid File selected. Please select an Non-encrypted File");
                openFileDialog1.FileName = "";
            }
            else
            {
                ext = Path.GetExtension(openFileDialog1.FileName);
            }
        }

        //Encryption
        private void Encrypt(string inputFile, string outputFile, string password)
        {
            byte[] salt = GenSalt();
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwords, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;
            using (FileStream fsCrypt = new FileStream(outputFile + ".aes", FileMode.Create))
            {
                fsCrypt.Write(salt, 0, salt.Length);
                using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                    {
                        byte[] buffer = new byte[1048576];
                        int read;
                        while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cs.Write(buffer, 0, read);
                        }
                    }
                }
            }
            MessageBox.Show("File Encrypted");
            File.Delete(inputFile); //delete unencrypted file
        }

        private void btnEnSave_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Please select a File to Encrypt");
            }
            else
            {
                if (txtPassEncrypt.Text == "")
                {
                    MessageBox.Show("Please enter a Password to Encrypt the File");
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    {
                        MessageBox.Show("Please select a Destination for the Encrypted File");
                    }
                    else
                    {
                        Encrypt(openFileDialog1.FileName, saveFileDialog1.FileName, txtPassEncrypt.Text);
                        txtPassEncrypt.Text = "";
                    }
                }
            }
        }

        private void btnEncrypt_DragDrop(object sender, DragEventArgs e)
        {
            filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (filePaths[0] != "" && Path.GetExtension(filePaths[0]) == ".aes")
            {
                MessageBox.Show("Invalid File selected. Please select an Non-encrypted File");
                openFileDialog1.FileName = "";
            }
            else
            {
                openFileDialog1.FileName = filePaths[0];
                ext = Path.GetExtension(openFileDialog1.FileName);
                MessageBox.Show("File selected");
            }
        }

        private void btnEncrypt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Decryption
        private void Decrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwords = Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];
            using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
            {
                fsCrypt.Read(salt, 0, salt.Length);
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                var key = new Rfc2898DeriveBytes(passwords, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Padding = PaddingMode.PKCS7;
                AES.Mode = CipherMode.CFB;

                try
                {
                    using (CryptoStream cryptoStream = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        //save to file with orginal extension
                        using (FileStream fsOut = new FileStream(outputFile + ext, FileMode.Create))
                        {
                            try
                            {
                                int read;
                                byte[] buffer = new byte[1048576];
                                while ((read = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fsOut.Write(buffer, 0, read);
                                }
                                MessageBox.Show("File Decrypted");
                            }
                            catch
                            {
                                MessageBox.Show("Wrong Password");
                                File.Delete(outputFile); //delete failed unencrypted file
                            }
                        }
                    }
                }
                catch
                {
                    txtPassDecrypt.Text = "";
                }
            }
        }

        //Decrypt Button
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != "" && Path.GetExtension(openFileDialog1.FileName) != ".aes")
            {
                MessageBox.Show("Invalid File selected. Please select an Encrypted File");
                openFileDialog2.FileName = "";
            }
        }

        private void btnDeSave_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.FileName == "")
            {
                MessageBox.Show("Please select a File to Decrypt");
            }
            else
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("Please select a Destination for the Decrypted File");
                }
                else
                {
                    Decrypt(openFileDialog2.FileName, saveFileDialog2.FileName, txtPassDecrypt.Text);
                    txtPassDecrypt.Text = "";
                }
            }
        }

        private void btnDecrypt_DragDrop(object sender, DragEventArgs e)
        {
            filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
            if (filePaths[0] != "" && Path.GetExtension(filePaths[0]) != ".aes")
            {
                MessageBox.Show("Invalid File selected. Please select an Encrypted File");
                openFileDialog2.FileName = "";
            }
            else
            {
                openFileDialog2.FileName = filePaths[0];
                MessageBox.Show("File selected");
            }
        }

        private void btnDecrypt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
