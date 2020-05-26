namespace ClashOfBlocks
{
    partial class FrmRegister
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.txtBoxRePass = new System.Windows.Forms.TextBox();
            this.lblPassRpt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblNKupljeno = new System.Windows.Forms.Label();
            this.lblNivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(361, 174);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(156, 22);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.Leave += new System.EventHandler(this.TxtBoxName_Leave);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(361, 226);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(156, 22);
            this.txtBoxPass.TabIndex = 1;
            this.txtBoxPass.Leave += new System.EventHandler(this.TxtBoxPass_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(253, 177);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(253, 229);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password: ";
            // 
            // lblGame
            // 
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGame.Location = new System.Drawing.Point(78, 45);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(673, 107);
            this.lblGame.TabIndex = 5;
            this.lblGame.Text = "Clash Of Blocks";
            // 
            // txtBoxRePass
            // 
            this.txtBoxRePass.Location = new System.Drawing.Point(361, 279);
            this.txtBoxRePass.Name = "txtBoxRePass";
            this.txtBoxRePass.Size = new System.Drawing.Size(156, 22);
            this.txtBoxRePass.TabIndex = 6;
            this.txtBoxRePass.Leave += new System.EventHandler(this.TxtBoxRePass_Leave);
            // 
            // lblPassRpt
            // 
            this.lblPassRpt.AutoSize = true;
            this.lblPassRpt.Location = new System.Drawing.Point(253, 282);
            this.lblPassRpt.Name = "lblPassRpt";
            this.lblPassRpt.Size = new System.Drawing.Size(102, 17);
            this.lblPassRpt.TabIndex = 7;
            this.lblPassRpt.Text = "Ponovite Pass:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(253, 336);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email: ";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(361, 333);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(156, 22);
            this.txtBoxEmail.TabIndex = 9;
            this.txtBoxEmail.Leave += new System.EventHandler(this.TxtBoxEmail_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(287, 378);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(189, 43);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Napravi Account";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Location = new System.Drawing.Point(632, 189);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(16, 17);
            this.lblCoins.TabIndex = 11;
            this.lblCoins.Text = "0";
            // 
            // lblNKupljeno
            // 
            this.lblNKupljeno.AutoSize = true;
            this.lblNKupljeno.Location = new System.Drawing.Point(635, 245);
            this.lblNKupljeno.Name = "lblNKupljeno";
            this.lblNKupljeno.Size = new System.Drawing.Size(87, 17);
            this.lblNKupljeno.TabIndex = 12;
            this.lblNKupljeno.Text = "NijeKupljeno";
            // 
            // lblNivo
            // 
            this.lblNivo.AutoSize = true;
            this.lblNivo.Location = new System.Drawing.Point(635, 306);
            this.lblNivo.Name = "lblNivo";
            this.lblNivo.Size = new System.Drawing.Size(16, 17);
            this.lblNivo.TabIndex = 13;
            this.lblNivo.Text = "1";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNivo);
            this.Controls.Add(this.lblNKupljeno);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassRpt);
            this.Controls.Add(this.txtBoxRePass);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxName);
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.TextBox txtBoxRePass;
        private System.Windows.Forms.Label lblPassRpt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblNKupljeno;
        private System.Windows.Forms.Label lblNivo;
    }
}