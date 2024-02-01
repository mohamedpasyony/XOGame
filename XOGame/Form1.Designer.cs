namespace XOGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Side_Panel = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            TwoPlayers_btn = new Button();
            SinglePlayer_btn = new Button();
            GameOptions_btn = new Button();
            Logo_Panel = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ChildForm_panel = new Panel();
            Side_Panel.SuspendLayout();
            panel1.SuspendLayout();
            Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ChildForm_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Side_Panel
            // 
            Side_Panel.BackColor = SystemColors.Highlight;
            Side_Panel.Controls.Add(button1);
            Side_Panel.Controls.Add(panel1);
            Side_Panel.Controls.Add(GameOptions_btn);
            Side_Panel.Controls.Add(Logo_Panel);
            Side_Panel.Dock = DockStyle.Left;
            Side_Panel.Location = new Point(0, 0);
            Side_Panel.Margin = new Padding(4);
            Side_Panel.Name = "Side_Panel";
            Side_Panel.Size = new Size(322, 628);
            Side_Panel.TabIndex = 0;
            Side_Panel.Paint += Side_Panel_Paint;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 372);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(322, 58);
            button1.TabIndex = 4;
            button1.Text = "Scores";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TwoPlayers_btn);
            panel1.Controls.Add(SinglePlayer_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 83);
            panel1.TabIndex = 3;
            // 
            // TwoPlayers_btn
            // 
            TwoPlayers_btn.Dock = DockStyle.Top;
            TwoPlayers_btn.FlatAppearance.BorderSize = 0;
            TwoPlayers_btn.FlatStyle = FlatStyle.Flat;
            TwoPlayers_btn.Font = new Font("Microsoft New Tai Lue", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TwoPlayers_btn.ForeColor = Color.Gainsboro;
            TwoPlayers_btn.Location = new Point(0, 41);
            TwoPlayers_btn.Name = "TwoPlayers_btn";
            TwoPlayers_btn.Padding = new Padding(35, 0, 0, 0);
            TwoPlayers_btn.Size = new Size(322, 39);
            TwoPlayers_btn.TabIndex = 2;
            TwoPlayers_btn.Text = "1 VS 1";
            TwoPlayers_btn.TextAlign = ContentAlignment.MiddleLeft;
            TwoPlayers_btn.UseVisualStyleBackColor = true;
            TwoPlayers_btn.Click += TwoPlayers_btn_Click_1;
            // 
            // SinglePlayer_btn
            // 
            SinglePlayer_btn.Dock = DockStyle.Top;
            SinglePlayer_btn.FlatAppearance.BorderSize = 0;
            SinglePlayer_btn.FlatStyle = FlatStyle.Flat;
            SinglePlayer_btn.Font = new Font("Microsoft New Tai Lue", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SinglePlayer_btn.ForeColor = Color.Gainsboro;
            SinglePlayer_btn.Location = new Point(0, 0);
            SinglePlayer_btn.Name = "SinglePlayer_btn";
            SinglePlayer_btn.Padding = new Padding(35, 0, 0, 0);
            SinglePlayer_btn.Size = new Size(322, 41);
            SinglePlayer_btn.TabIndex = 1;
            SinglePlayer_btn.Text = "Single Player";
            SinglePlayer_btn.TextAlign = ContentAlignment.MiddleLeft;
            SinglePlayer_btn.UseVisualStyleBackColor = true;
            SinglePlayer_btn.Click += SinglePlayer_btn_Click;
            // 
            // GameOptions_btn
            // 
            GameOptions_btn.Dock = DockStyle.Top;
            GameOptions_btn.FlatAppearance.BorderSize = 0;
            GameOptions_btn.FlatStyle = FlatStyle.Flat;
            GameOptions_btn.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GameOptions_btn.ForeColor = Color.Gainsboro;
            GameOptions_btn.Location = new Point(0, 231);
            GameOptions_btn.Name = "GameOptions_btn";
            GameOptions_btn.Padding = new Padding(10, 0, 0, 0);
            GameOptions_btn.Size = new Size(322, 58);
            GameOptions_btn.TabIndex = 2;
            GameOptions_btn.Text = "Game Options";
            GameOptions_btn.TextAlign = ContentAlignment.MiddleLeft;
            GameOptions_btn.UseVisualStyleBackColor = true;
            GameOptions_btn.Click += GameOptions_btn_Click;
            // 
            // Logo_Panel
            // 
            Logo_Panel.Controls.Add(pictureBox2);
            Logo_Panel.Controls.Add(pictureBox1);
            Logo_Panel.Dock = DockStyle.Top;
            Logo_Panel.Location = new Point(0, 0);
            Logo_Panel.Name = "Logo_Panel";
            Logo_Panel.Size = new Size(322, 231);
            Logo_Panel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(322, 231);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(423, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(249, 232);
            label1.Name = "label1";
            label1.Size = new Size(629, 68);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Game";
            // 
            // ChildForm_panel
            // 
            ChildForm_panel.AutoSize = true;
            ChildForm_panel.BackColor = SystemColors.ActiveCaptionText;
            ChildForm_panel.Controls.Add(label1);
            ChildForm_panel.Dock = DockStyle.Fill;
            ChildForm_panel.Location = new Point(322, 0);
            ChildForm_panel.Name = "ChildForm_panel";
            ChildForm_panel.Size = new Size(1085, 628);
            ChildForm_panel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 628);
            Controls.Add(ChildForm_panel);
            Controls.Add(Side_Panel);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Side_Panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ChildForm_panel.ResumeLayout(false);
            ChildForm_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Side_Panel;
        private Panel Logo_Panel;
        private Button GameOptions_btn;
        private Panel panel1;
        private Button SinglePlayer_btn;
        private Button TwoPlayers_btn;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        public Panel ChildForm_panel;
    }
}