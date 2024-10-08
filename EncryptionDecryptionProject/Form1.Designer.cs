namespace EncryptionDecryptionProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTextDecrypted = new System.Windows.Forms.Panel();
            this.OpenFileMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToGetTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.OpenFileMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileMenueStrip2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOriginalText = new System.Windows.Forms.Label();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTextDecrypted = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTextDecrypted.SuspendLayout();
            this.OpenFileMenuStrip1.SuspendLayout();
            this.OpenFileMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(893, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(794, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text Decrypted :";
            // 
            // pnlTextDecrypted
            // 
            this.pnlTextDecrypted.AutoScroll = true;
            this.pnlTextDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextDecrypted.ContextMenuStrip = this.OpenFileMenuStrip1;
            this.pnlTextDecrypted.Controls.Add(this.txtDecryptedText);
            this.pnlTextDecrypted.Location = new System.Drawing.Point(793, 222);
            this.pnlTextDecrypted.Name = "pnlTextDecrypted";
            this.pnlTextDecrypted.Size = new System.Drawing.Size(465, 194);
            this.pnlTextDecrypted.TabIndex = 3;
            // 
            // OpenFileMenuStrip1
            // 
            this.OpenFileMenuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OpenFileMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToGetTextToolStripMenuItem});
            this.OpenFileMenuStrip1.Name = "OpenFileMenuStrip";
            this.OpenFileMenuStrip1.Size = new System.Drawing.Size(255, 28);
            // 
            // openFileToGetTextToolStripMenuItem
            // 
            this.openFileToGetTextToolStripMenuItem.Name = "openFileToGetTextToolStripMenuItem";
            this.openFileToGetTextToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.openFileToGetTextToolStripMenuItem.Text = "Open File To Get Text";
            this.openFileToGetTextToolStripMenuItem.Click += new System.EventHandler(this.openFileToGetTextToolStripMenuItem_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.BackColor = System.Drawing.Color.White;
            this.txtDecryptedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecryptedText.ContextMenuStrip = this.OpenFileMenuStrip2;
            this.txtDecryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecryptedText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptedText.ForeColor = System.Drawing.Color.LightGray;
            this.txtDecryptedText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDecryptedText.Location = new System.Drawing.Point(0, 0);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecryptedText.Size = new System.Drawing.Size(463, 192);
            this.txtDecryptedText.TabIndex = 3;
            this.txtDecryptedText.Text = "Enter text decrypted or choose file decrypted";
            this.txtDecryptedText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // OpenFileMenuStrip2
            // 
            this.OpenFileMenuStrip2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OpenFileMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenueStrip2});
            this.OpenFileMenuStrip2.Name = "OpenFileMenuStrip";
            this.OpenFileMenuStrip2.Size = new System.Drawing.Size(255, 28);
            // 
            // openFileMenueStrip2
            // 
            this.openFileMenueStrip2.Name = "openFileMenueStrip2";
            this.openFileMenueStrip2.Size = new System.Drawing.Size(254, 24);
            this.openFileMenueStrip2.Text = "Open File To Get Text";
            this.openFileMenueStrip2.Click += new System.EventHandler(this.openFileMenueStrip2_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackColor = System.Drawing.Color.Orange;
            this.btnDecryption.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryption.Location = new System.Drawing.Point(834, 452);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(161, 50);
            this.btnDecryption.TabIndex = 4;
            this.btnDecryption.Text = "Decryption";
            this.btnDecryption.UseVisualStyleBackColor = false;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnReset2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(1073, 452);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(161, 50);
            this.btnReset2.TabIndex = 5;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(794, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Original Text :";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.OpenFileMenuStrip1;
            this.panel1.Controls.Add(this.lbOriginalText);
            this.panel1.Location = new System.Drawing.Point(794, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 194);
            this.panel1.TabIndex = 8;
            // 
            // lbOriginalText
            // 
            this.lbOriginalText.BackColor = System.Drawing.Color.White;
            this.lbOriginalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOriginalText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginalText.Location = new System.Drawing.Point(0, 0);
            this.lbOriginalText.Name = "lbOriginalText";
            this.lbOriginalText.Size = new System.Drawing.Size(463, 192);
            this.lbOriginalText.TabIndex = 1;
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.Orange;
            this.btnSave2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(946, 811);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(161, 50);
            this.btnSave2.TabIndex = 5;
            this.btnSave2.Text = "Save ";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.BackColor = System.Drawing.Color.White;
            this.txtEncryptedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEncryptedText.ContextMenuStrip = this.OpenFileMenuStrip1;
            this.txtEncryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncryptedText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedText.ForeColor = System.Drawing.Color.LightGray;
            this.txtEncryptedText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEncryptedText.Location = new System.Drawing.Point(0, 0);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptedText.Size = new System.Drawing.Size(463, 192);
            this.txtEncryptedText.TabIndex = 0;
            this.txtEncryptedText.Text = "Enter text encrypted or choose file encrypted";
            this.txtEncryptedText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtEncryptedText);
            this.panel2.Location = new System.Drawing.Point(153, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 194);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(155, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Original Text :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 54);
            this.label6.TabIndex = 12;
            this.label6.Text = "Encryption";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbTextDecrypted);
            this.panel3.Location = new System.Drawing.Point(153, 601);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 194);
            this.panel3.TabIndex = 18;
            // 
            // lbTextDecrypted
            // 
            this.lbTextDecrypted.BackColor = System.Drawing.Color.White;
            this.lbTextDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTextDecrypted.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextDecrypted.Location = new System.Drawing.Point(0, 0);
            this.lbTextDecrypted.Name = "lbTextDecrypted";
            this.lbTextDecrypted.Size = new System.Drawing.Size(463, 192);
            this.lbTextDecrypted.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(160, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "Text Decrypted :";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.OrangeRed;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(424, 452);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 50);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEncryption
            // 
            this.btnEncryption.BackColor = System.Drawing.Color.Orange;
            this.btnEncryption.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryption.Location = new System.Drawing.Point(180, 452);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(161, 50);
            this.btnEncryption.TabIndex = 1;
            this.btnEncryption.Text = "Encryption";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(293, 811);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.BackgroundImage = global::EncryptionDecryptionProject.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1317, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 51);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1393, 933);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.pnlTextDecrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.pnlTextDecrypted.ResumeLayout(false);
            this.pnlTextDecrypted.PerformLayout();
            this.OpenFileMenuStrip1.ResumeLayout(false);
            this.OpenFileMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTextDecrypted;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.ContextMenuStrip OpenFileMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToGetTextToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Label lbOriginalText;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTextDecrypted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip OpenFileMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openFileMenueStrip2;
    }
}

