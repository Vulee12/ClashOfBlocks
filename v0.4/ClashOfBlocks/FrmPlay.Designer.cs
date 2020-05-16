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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZv3)).BeginInit();
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
            this.btnStart.Location = new System.Drawing.Point(489, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(268, 56);
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
            this.btnReset.Location = new System.Drawing.Point(489, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(268, 56);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(489, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(268, 56);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Level";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(489, 329);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(268, 56);
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
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 476);
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
    }
}