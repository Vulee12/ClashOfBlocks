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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblGame = new System.Windows.Forms.Label();
            this.txtBoxPassRpt = new System.Windows.Forms.TextBox();
            this.lblPassRpt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(319, 239);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(156, 22);
            this.txtBoxName.TabIndex = 0;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(319, 283);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(156, 22);
            this.txtBoxPass.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(215, 242);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(215, 286);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password: ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(276, 378);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(161, 45);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
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
            // txtBoxPassRpt
            // 
            this.txtBoxPassRpt.Location = new System.Drawing.Point(319, 328);
            this.txtBoxPassRpt.Name = "txtBoxPassRpt";
            this.txtBoxPassRpt.Size = new System.Drawing.Size(156, 22);
            this.txtBoxPassRpt.TabIndex = 6;
            // 
            // lblPassRpt
            // 
            this.lblPassRpt.AutoSize = true;
            this.lblPassRpt.Location = new System.Drawing.Point(215, 331);
            this.lblPassRpt.Name = "lblPassRpt";
            this.lblPassRpt.Size = new System.Drawing.Size(102, 17);
            this.lblPassRpt.TabIndex = 7;
            this.lblPassRpt.Text = "Ponovite Pass:";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassRpt);
            this.Controls.Add(this.txtBoxPassRpt);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.btnRegister);
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
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.TextBox txtBoxPassRpt;
        private System.Windows.Forms.Label lblPassRpt;
    }
}