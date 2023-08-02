
namespace CMPG215
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtPassEncrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeSave = new System.Windows.Forms.Button();
            this.txtPassDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AllowDrop = true;
            this.btnEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.BackgroundImage")));
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncrypt.Location = new System.Drawing.Point(36, 33);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(136, 134);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.btnEncrypt.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnEncrypt_DragDrop);
            this.btnEncrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnEncrypt_DragEnter);
            // 
            // txtPassEncrypt
            // 
            this.txtPassEncrypt.Location = new System.Drawing.Point(36, 242);
            this.txtPassEncrypt.Name = "txtPassEncrypt";
            this.txtPassEncrypt.PasswordChar = '*';
            this.txtPassEncrypt.Size = new System.Drawing.Size(154, 20);
            this.txtPassEncrypt.TabIndex = 1;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.AllowDrop = true;
            this.btnDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.BackgroundImage")));
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecrypt.Location = new System.Drawing.Point(41, 33);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(136, 134);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            this.btnDecrypt.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnDecrypt_DragDrop);
            this.btnDecrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnDecrypt_DragEnter);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(33, 226);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(157, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Enter Password to Encrypt with:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Browse or Drag and Drop a File to Decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Browse or Drag and Drop a File to Encrypt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnSave);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassEncrypt);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 350);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // btnEnSave
            // 
            this.btnEnSave.Location = new System.Drawing.Point(36, 292);
            this.btnEnSave.Name = "btnEnSave";
            this.btnEnSave.Size = new System.Drawing.Size(136, 36);
            this.btnEnSave.TabIndex = 2;
            this.btnEnSave.Text = "Save Encrypted File";
            this.btnEnSave.UseVisualStyleBackColor = true;
            this.btnEnSave.Click += new System.EventHandler(this.btnEnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeSave);
            this.groupBox2.Controls.Add(this.txtPassDecrypt);
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 350);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // btnDeSave
            // 
            this.btnDeSave.Location = new System.Drawing.Point(43, 292);
            this.btnDeSave.Name = "btnDeSave";
            this.btnDeSave.Size = new System.Drawing.Size(134, 36);
            this.btnDeSave.TabIndex = 2;
            this.btnDeSave.Text = "Save Decrypted File";
            this.btnDeSave.UseVisualStyleBackColor = true;
            this.btnDeSave.Click += new System.EventHandler(this.btnDeSave_Click);
            // 
            // txtPassDecrypt
            // 
            this.txtPassDecrypt.Location = new System.Drawing.Point(39, 242);
            this.txtPassDecrypt.Name = "txtPassDecrypt";
            this.txtPassDecrypt.PasswordChar = '*';
            this.txtPassDecrypt.Size = new System.Drawing.Size(154, 20);
            this.txtPassDecrypt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Password to Decrypt File:";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Encryption Software";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtPassEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnSave;
        private System.Windows.Forms.Button btnDeSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

