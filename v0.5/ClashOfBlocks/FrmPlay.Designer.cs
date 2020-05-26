namespace ClashOfBlocks
{
    partial class FrmPlay
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
            this.pnlTeren = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerSirenje = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.picBoxZv1 = new System.Windows.Forms.PictureBox();
            this.picBoxZv2 = new System.Windows.Forms.PictureBox();
            this.picBoxZv3 = new System.Windows.Forms.PictureBox();
            this.lblProcenat = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblNivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTeren
            // 
            this.pnlTeren.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlTeren.Location = new System.Drawing.Point(12, 12);
            this.pnlTeren.Name = "pnlTeren";
            this.pnlTeren.Size = new System.Drawing.Size(450, 450);
            this.pnlTeren.TabIndex = 0;
            this.pnlTeren.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTeren_Paint);
            this.pnlTeren.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlTeren_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(489, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(268, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timerSirenje
            // 
            this.timerSirenje.Tick += new System.EventHandler(this.TimerSirenje_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(489, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(268, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(489, 412);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(268, 50);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(489, 356);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(268, 50);
            this.btnRetry.TabIndex = 4;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.BtnRetry_Click);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(549, 283);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(0, 17);
            this.lblStat.TabIndex = 5;
            // 
            // picBoxZv1
            // 
            this.picBoxZv1.Image = global::ClashOfBlocks.Properties.Resources.zvezdica;
            this.picBoxZv1.Location = new System.Drawing.Point(524, 215);
            this.picBoxZv1.Name = "picBoxZv1";
            this.picBoxZv1.Size = new System.Drawing.Size(56, 55);
            this.picBoxZv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxZv1.TabIndex = 6;
            this.picBoxZv1.TabStop = false;
            // 
            // picBoxZv2
            // 
            this.picBoxZv2.Image = global::ClashOfBlocks.Properties.Resources.zvezdica;
            this.picBoxZv2.Location = new System.Drawing.Point(586, 215);
            this.picBoxZv2.Name = "picBoxZv2";
            this.picBoxZv2.Size = new System.Drawing.Size(56, 55);
            this.picBoxZv2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxZv2.TabIndex = 7;
            this.picBoxZv2.TabStop = false;
            // 
            // picBoxZv3
            // 
            this.picBoxZv3.Image = global::ClashOfBlocks.Properties.Resources.zvezdica;
            this.picBoxZv3.Location = new System.Drawing.Point(648, 215);
            this.picBoxZv3.Name = "picBoxZv3";
            this.picBoxZv3.Size = new System.Drawing.Size(56, 55);
            this.picBoxZv3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxZv3.TabIndex = 8;
            this.picBoxZv3.TabStop = false;
            // 
            // lblProcenat
            // 
            this.lblProcenat.AutoSize = true;
            this.lblProcenat.Location = new System.Drawing.Point(606, 309);
            this.lblProcenat.Name = "lblProcenat";
            this.lblProcenat.Size = new System.Drawing.Size(0, 17);
            this.lblProcenat.TabIndex = 9;
            // 
            // lblLvl
            // 
            this.lblLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl.Location = new System.Drawing.Point(473, 24);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(91, 38);
            this.lblLvl.TabIndex = 10;
            this.lblLvl.Text = "Level: ";
            // 
            // lblNivo
            // 
            this.lblNivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivo.Location = new System.Drawing.Point(549, 24);
            this.lblNivo.Name = "lblNivo";
            this.lblNivo.Size = new System.Drawing.Size(73, 38);
            this.lblNivo.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClashOfBlocks.Properties.Resources.Coins;
            this.pictureBox1.Location = new System.Drawing.Point(628, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblCoins
            // 
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(693, 24);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(73, 38);
            this.lblCoins.TabIndex = 13;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 476);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNivo);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.lblProcenat);
            this.Controls.Add(this.picBoxZv3);
            this.Controls.Add(this.picBoxZv2);
            this.Controls.Add(this.picBoxZv1);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlTeren);
            this.Name = "FrmPlay";
            this.Text = "Clash Of Blocks";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeren;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerSirenje;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.PictureBox picBoxZv1;
        private System.Windows.Forms.PictureBox picBoxZv2;
        private System.Windows.Forms.PictureBox picBoxZv3;
        private System.Windows.Forms.Label lblProcenat;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblNivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCoins;
    }
}