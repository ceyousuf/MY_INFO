namespace MY_INFO
{
    partial class frmMyInfo
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
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.txtOutputData = new System.Windows.Forms.TextBox();
            this.rdoEncrypt = new System.Windows.Forms.RadioButton();
            this.rdoDecrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(46, 54);
            this.txtSecretKey.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.PasswordChar = '*';
            this.txtSecretKey.Size = new System.Drawing.Size(292, 29);
            this.txtSecretKey.TabIndex = 0;
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(46, 130);
            this.txtInputData.Margin = new System.Windows.Forms.Padding(6);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(292, 29);
            this.txtInputData.TabIndex = 0;
            // 
            // txtOutputData
            // 
            this.txtOutputData.Location = new System.Drawing.Point(46, 257);
            this.txtOutputData.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutputData.Name = "txtOutputData";
            this.txtOutputData.PasswordChar = '*';
            this.txtOutputData.ReadOnly = true;
            this.txtOutputData.Size = new System.Drawing.Size(292, 29);
            this.txtOutputData.TabIndex = 0;
            // 
            // rdoEncrypt
            // 
            this.rdoEncrypt.AutoSize = true;
            this.rdoEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEncrypt.Location = new System.Drawing.Point(50, 168);
            this.rdoEncrypt.Name = "rdoEncrypt";
            this.rdoEncrypt.Size = new System.Drawing.Size(78, 20);
            this.rdoEncrypt.TabIndex = 1;
            this.rdoEncrypt.TabStop = true;
            this.rdoEncrypt.Text = "Encrypt";
            this.rdoEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdoDecrypt
            // 
            this.rdoDecrypt.AutoSize = true;
            this.rdoDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDecrypt.Location = new System.Drawing.Point(163, 168);
            this.rdoDecrypt.Name = "rdoDecrypt";
            this.rdoDecrypt.Size = new System.Drawing.Size(80, 20);
            this.rdoDecrypt.TabIndex = 1;
            this.rdoDecrypt.TabStop = true;
            this.rdoDecrypt.Text = "Decrypt";
            this.rdoDecrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Secret Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output Data";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(46, 295);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(292, 41);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyClipboard.Location = new System.Drawing.Point(341, 257);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(33, 29);
            this.btnCopyClipboard.TabIndex = 4;
            this.btnCopyClipboard.Text = "....";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.btnCopyClipboard_Click);
            // 
            // frmMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 547);
            this.Controls.Add(this.btnCopyClipboard);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoDecrypt);
            this.Controls.Add(this.rdoEncrypt);
            this.Controls.Add(this.txtOutputData);
            this.Controls.Add(this.txtInputData);
            this.Controls.Add(this.txtSecretKey);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY INFORMATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.TextBox txtOutputData;
        private System.Windows.Forms.RadioButton rdoEncrypt;
        private System.Windows.Forms.RadioButton rdoDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCopyClipboard;
    }
}