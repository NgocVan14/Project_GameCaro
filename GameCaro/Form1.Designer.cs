namespace GameCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbAvatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.undobtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(274, 26);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(922, 592);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pctbAvatar);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 203);
            this.panel2.TabIndex = 1;
            // 
            // pctbAvatar
            // 
            this.pctbAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.pctbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbAvatar.Image = global::GameCaro.Properties.Resources.avatar_2;
            this.pctbAvatar.Location = new System.Drawing.Point(4, 0);
            this.pctbAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pctbAvatar.Name = "pctbAvatar";
            this.pctbAvatar.Size = new System.Drawing.Size(212, 203);
            this.pctbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbAvatar.TabIndex = 0;
            this.pctbAvatar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Location = new System.Drawing.Point(12, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 208);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "IN TURN COME";
            // 
            // pctbMark
            // 
            this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
            this.pctbMark.Location = new System.Drawing.Point(26, 58);
            this.pctbMark.Margin = new System.Windows.Forms.Padding(4);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(135, 131);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(4, 4);
            this.btnLAN.Margin = new System.Windows.Forms.Padding(4);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(212, 43);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "CONNECT";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(24, 308);
            this.txbIP.Margin = new System.Windows.Forms.Padding(4);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(216, 22);
            this.txbIP.TabIndex = 3;
            this.txbIP.Text = "127.0.0.1";
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(4, 4);
            this.prcbCoolDown.Margin = new System.Windows.Forms.Padding(4);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(175, 28);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(24, 267);
            this.txbPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(216, 22);
            this.txbPlayerName.TabIndex = 0;
            this.txbPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // undobtn
            // 
            this.undobtn.BackColor = System.Drawing.Color.Fuchsia;
            this.undobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.undobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undobtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.undobtn.Location = new System.Drawing.Point(26, 108);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(135, 43);
            this.undobtn.TabIndex = 4;
            this.undobtn.Text = "UNDO";
            this.undobtn.UseVisualStyleBackColor = false;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.Purple;
            this.quitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitbtn.Location = new System.Drawing.Point(26, 192);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(135, 43);
            this.quitbtn.TabIndex = 4;
            this.quitbtn.Text = "QUIT";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.quitbtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.Plum;
            this.newbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newbtn.Location = new System.Drawing.Point(26, 27);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(135, 43);
            this.newbtn.TabIndex = 4;
            this.newbtn.Text = "NEW GAME";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.newbtn);
            this.panel1.Controls.Add(this.quitbtn);
            this.panel1.Controls.Add(this.undobtn);
            this.panel1.Location = new System.Drawing.Point(13, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 261);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.prcbCoolDown);
            this.panel4.Location = new System.Drawing.Point(12, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 36);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.btnLAN);
            this.panel5.Location = new System.Drawing.Point(24, 567);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 51);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(24, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 212);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Location = new System.Drawing.Point(1229, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 591);
            this.panel7.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1449, 640);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.txbPlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Game Caro LAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Button undobtn;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button quitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}

