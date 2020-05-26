namespace ClashOfBlocks
{
    partial class FrmIgra
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
            this.lblGame = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.picBoxSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGame.Location = new System.Drawing.Point(84, 74);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(679, 99);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "Clash Of Blocks";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(280, 216);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(228, 63);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnShop
            // 
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Location = new System.Drawing.Point(280, 307);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(228, 71);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.BtnShop_Click);
            // 
            // picBoxSettings
            // 
            this.picBoxSettings.Image = global::ClashOfBlocks.Properties.Resources.settings;
            this.picBoxSettings.Location = new System.Drawing.Point(716, 12);
            this.picBoxSettings.Name = "picBoxSettings";
            this.picBoxSettings.Size = new System.Drawing.Size(72, 69);
            this.picBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSettings.TabIndex = 3;
            this.picBoxSettings.TabStop = false;
            this.picBoxSettings.Click += new System.EventHandler(this.PicBoxSettings_Click);
            // 
            // FrmIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxSettings);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGame);
            this.Name = "FrmIgra";
            this.Text = "Clash Of Blocks";
            this.Load += new System.EventHandler(this.FrmIgra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.PictureBox picBoxSettings;
    }
}