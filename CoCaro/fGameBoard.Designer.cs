namespace CoCaro
{
    partial class fGameBoard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGameBoard));
            panel1 = new Panel();
            btnMusic = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlBanCo = new Panel();
            btnExit = new Button();
            btnPlayervsCom = new Button();
            btnPlayervsPlayer = new Button();
            pnlChuChay = new Panel();
            lblChuoiChu = new Label();
            ptbLogo = new PictureBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            tmChuChay = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlChuChay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(btnMusic);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pnlBanCo);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnPlayervsCom);
            panel1.Controls.Add(btnPlayervsPlayer);
            panel1.Controls.Add(pnlChuChay);
            panel1.Controls.Add(ptbLogo);
            panel1.Location = new Point(2, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 643);
            panel1.TabIndex = 0;
            // 
            // btnMusic
            // 
            btnMusic.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMusic.Location = new Point(146, 586);
            btnMusic.Name = "btnMusic";
            btnMusic.Size = new Size(111, 46);
            btnMusic.TabIndex = 8;
            btnMusic.Text = "Bật/Tắt BGM";
            btnMusic.UseVisualStyleBackColor = true;
            btnMusic.Click += btnMusic_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.X;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(212, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 62);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.O;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(212, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 62);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pnlBanCo
            // 
            pnlBanCo.BackColor = SystemColors.ControlLightLight;
            pnlBanCo.Location = new Point(293, 6);
            pnlBanCo.Name = "pnlBanCo";
            pnlBanCo.Size = new Size(626, 626);
            pnlBanCo.TabIndex = 5;
            pnlBanCo.Paint += pnlBanCo_Paint;
            pnlBanCo.MouseClick += pnlBanCo_MouseClick;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(29, 586);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayervsCom
            // 
            btnPlayervsCom.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayervsCom.Location = new Point(24, 517);
            btnPlayervsCom.Name = "btnPlayervsCom";
            btnPlayervsCom.Size = new Size(230, 63);
            btnPlayervsCom.TabIndex = 3;
            btnPlayervsCom.Text = "Player Vs Computer";
            btnPlayervsCom.UseVisualStyleBackColor = true;
            btnPlayervsCom.Click += btnPlayervsCom_Click;
            // 
            // btnPlayervsPlayer
            // 
            btnPlayervsPlayer.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayervsPlayer.Location = new Point(24, 447);
            btnPlayervsPlayer.Name = "btnPlayervsPlayer";
            btnPlayervsPlayer.Size = new Size(230, 64);
            btnPlayervsPlayer.TabIndex = 2;
            btnPlayervsPlayer.Text = "Player Vs Player";
            btnPlayervsPlayer.UseVisualStyleBackColor = true;
            btnPlayervsPlayer.Click += btnPlayervsPlayer_Click;
            // 
            // pnlChuChay
            // 
            pnlChuChay.BorderStyle = BorderStyle.Fixed3D;
            pnlChuChay.Controls.Add(lblChuoiChu);
            pnlChuChay.Location = new Point(24, 206);
            pnlChuChay.Name = "pnlChuChay";
            pnlChuChay.Size = new Size(230, 235);
            pnlChuChay.TabIndex = 1;
            // 
            // lblChuoiChu
            // 
            lblChuoiChu.AutoSize = true;
            lblChuoiChu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChuoiChu.Location = new Point(3, 208);
            lblChuoiChu.Name = "lblChuoiChu";
            lblChuoiChu.Size = new Size(0, 23);
            lblChuoiChu.TabIndex = 0;
            // 
            // ptbLogo
            // 
            ptbLogo.BackColor = SystemColors.ControlLightLight;
            ptbLogo.BackgroundImage = (Image)resources.GetObject("ptbLogo.BackgroundImage");
            ptbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ptbLogo.BorderStyle = BorderStyle.FixedSingle;
            ptbLogo.Location = new Point(3, 6);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(203, 197);
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(128, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(128, 26);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // tmChuChay
            // 
            tmChuChay.Interval = 25;
            tmChuChay.Tick += tmchuChay_Tick;
            // 
            // fGameBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 674);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "fGameBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Caro";
            Load += fGameBoard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlChuChay.ResumeLayout(false);
            pnlChuChay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox ptbLogo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private Panel pnlChuChay;
        private Button btnExit;
        private Button btnPlayervsCom;
        private Button btnPlayervsPlayer;
        private Label lblChuoiChu;
        private Panel pnlBanCo;
        private System.Windows.Forms.Timer tmChuChay;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnMusic;
    }
}