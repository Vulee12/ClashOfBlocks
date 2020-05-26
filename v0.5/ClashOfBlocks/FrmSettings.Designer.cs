namespace ClashOfBlocks
{
    partial class FrmSettings
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
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnPassChng = new System.Windows.Forms.Button();
            this.txtBoxOPass = new System.Windows.Forms.TextBox();
            this.txtBoxNPass = new System.Windows.Forms.TextBox();
            this.txtBoxRePass = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblOPass = new System.Windows.Forms.Label();
            this.lblNPass = new System.Windows.Forms.Label();
            this.lblRePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSettings.Location = new System.Drawing.Point(64, 71);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(724, 116);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Account Settings";
            // 
            // btnPassChng
            // 
            this.btnPassChng.Location = new System.Drawing.Point(287, 190);
            this.btnPassChng.Name = "btnPassChng";
            this.btnPassChng.Size = new System.Drawing.Size(205, 44);
            this.btnPassChng.TabIndex = 1;
            this.btnPassChng.Text = "Promena Sifre";
            this.btnPassChng.UseVisualStyleBackColor = true;
            this.btnPassChng.Click += new System.EventHandler(this.BtnPassChng_Click);
            // 
            // txtBoxOPass
            // 
            this.txtBoxOPass.Location = new System.Drawing.Point(287, 264);
            this.txtBoxOPass.Name = "txtBoxOPass";
            this.txtBoxOPass.Size = new System.Drawing.Size(205, 22);
            this.txtBoxOPass.TabIndex = 2;
            this.txtBoxOPass.Leave += new System.EventHandler(this.TxtBoxOPass_Leave);
            // 
            // txtBoxNPass
            // 
            this.txtBoxNPass.Location = new System.Drawing.Point(287, 339);
            this.txtBoxNPass.Name = "txtBoxNPass";
            this.txtBoxNPass.Size = new System.Drawing.Size(205, 22);
            this.txtBoxNPass.TabIndex = 3;
            this.txtBoxNPass.Leave += new System.EventHandler(this.TxtBoxNPass_Leave);
            // 
            // txtBoxRePass
            // 
            this.txtBoxRePass.Location = new System.Drawing.Point(287, 379);
            this.txtBoxRePass.Name = "txtBoxRePass";
            this.txtBoxRePass.Size = new System.Drawing.Size(205, 22);
            this.txtBoxRePass.TabIndex = 4;
            this.txtBoxRePass.Leave += new System.EventHandler(this.TxtBoxRePass_Leave);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(526, 339);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 62);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblOPass
            // 
            this.lblOPass.AutoSize = true;
            this.lblOPass.Location = new System.Drawing.Point(146, 267);
            this.lblOPass.Name = "lblOPass";
            this.lblOPass.Size = new System.Drawing.Size(110, 17);
            this.lblOPass.TabIndex = 6;
            this.lblOPass.Text = "Stari Password: ";
            // 
            // lblNPass
            // 
            this.lblNPass.AutoSize = true;
            this.lblNPass.Location = new System.Drawing.Point(146, 342);
            this.lblNPass.Name = "lblNPass";
            this.lblNPass.Size = new System.Drawing.Size(109, 17);
            this.lblNPass.TabIndex = 7;
            this.lblNPass.Text = "Novi Password: ";
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Location = new System.Drawing.Point(146, 382);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(136, 17);
            this.lblRePass.TabIndex = 8;
            this.lblRePass.Text = "Ponovite Password: ";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRePass);
            this.Controls.Add(this.lblNPass);
            this.Controls.Add(this.lblOPass);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBoxRePass);
            this.Controls.Add(this.txtBoxNPass);
            this.Controls.Add(this.txtBoxOPass);
            this.Controls.Add(this.btnPassChng);
            this.Controls.Add(this.lblSettings);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnPassChng;
        private System.Windows.Forms.TextBox txtBoxOPass;
        private System.Windows.Forms.TextBox txtBoxNPass;
        private System.Windows.Forms.TextBox txtBoxRePass;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblOPass;
        private System.Windows.Forms.Label lblNPass;
        private System.Windows.Forms.Label lblRePass;
    }
}