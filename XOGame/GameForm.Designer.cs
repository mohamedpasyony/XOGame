namespace XOGame
{
    partial class GameForm
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
            panel1 = new Panel();
            Square9 = new Button();
            Square8 = new Button();
            Square7 = new Button();
            Square6 = new Button();
            Square5 = new Button();
            square4 = new Button();
            Square3 = new Button();
            Square2 = new Button();
            Square1 = new Button();
            StartGame_btn = new Button();
            Player1Name = new Label();
            Player2Name = new Label();
            Player1Score = new Label();
            Player2Score = new Label();
            button1 = new Button();
            button2 = new Button();
            Turn_Label = new Label();
            P1Sympol_label = new Label();
            P2Sympol_label = new Label();
            SaveScore_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Square9);
            panel1.Controls.Add(Square8);
            panel1.Controls.Add(Square7);
            panel1.Controls.Add(Square6);
            panel1.Controls.Add(Square5);
            panel1.Controls.Add(square4);
            panel1.Controls.Add(Square3);
            panel1.Controls.Add(Square2);
            panel1.Controls.Add(Square1);
            panel1.Location = new Point(35, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 471);
            panel1.TabIndex = 0;
            // 
            // Square9
            // 
            Square9.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square9.ForeColor = SystemColors.ControlText;
            Square9.Location = new Point(342, 340);
            Square9.Name = "Square9";
            Square9.Size = new Size(115, 115);
            Square9.TabIndex = 9;
            Square9.Tag = "8";
            Square9.UseVisualStyleBackColor = true;
            Square9.Click += Square9_Click;
            // 
            // Square8
            // 
            Square8.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square8.Location = new Point(188, 340);
            Square8.Name = "Square8";
            Square8.Size = new Size(115, 115);
            Square8.TabIndex = 8;
            Square8.Tag = "7";
            Square8.UseVisualStyleBackColor = true;
            Square8.Click += Square8_Click;
            // 
            // Square7
            // 
            Square7.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square7.Location = new Point(33, 340);
            Square7.Name = "Square7";
            Square7.Size = new Size(115, 115);
            Square7.TabIndex = 7;
            Square7.Tag = "6";
            Square7.UseVisualStyleBackColor = true;
            Square7.Click += Square7_Click;
            // 
            // Square6
            // 
            Square6.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square6.Location = new Point(342, 182);
            Square6.Name = "Square6";
            Square6.Size = new Size(115, 115);
            Square6.TabIndex = 6;
            Square6.Tag = "5";
            Square6.UseVisualStyleBackColor = true;
            Square6.Click += Square6_Click;
            // 
            // Square5
            // 
            Square5.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square5.Location = new Point(188, 182);
            Square5.Name = "Square5";
            Square5.Size = new Size(115, 115);
            Square5.TabIndex = 5;
            Square5.Tag = "4";
            Square5.UseVisualStyleBackColor = true;
            Square5.Click += Square5_Click;
            // 
            // square4
            // 
            square4.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            square4.Location = new Point(33, 182);
            square4.Name = "square4";
            square4.Size = new Size(115, 115);
            square4.TabIndex = 4;
            square4.Tag = "3";
            square4.UseVisualStyleBackColor = true;
            square4.Click += square4_Click;
            // 
            // Square3
            // 
            Square3.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square3.Location = new Point(342, 21);
            Square3.Name = "Square3";
            Square3.Size = new Size(115, 115);
            Square3.TabIndex = 3;
            Square3.Tag = "2";
            Square3.UseVisualStyleBackColor = true;
            Square3.Click += Square3_Click;
            // 
            // Square2
            // 
            Square2.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square2.Location = new Point(188, 21);
            Square2.Name = "Square2";
            Square2.Size = new Size(115, 115);
            Square2.TabIndex = 2;
            Square2.Tag = "1";
            Square2.UseVisualStyleBackColor = true;
            Square2.Click += Square2_Click;
            // 
            // Square1
            // 
            Square1.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            Square1.Location = new Point(33, 21);
            Square1.Name = "Square1";
            Square1.Size = new Size(115, 115);
            Square1.TabIndex = 1;
            Square1.Tag = "0";
            Square1.UseVisualStyleBackColor = true;
            Square1.Click += Square1_Click;
            // 
            // StartGame_btn
            // 
            StartGame_btn.BackColor = SystemColors.ActiveCaptionText;
            StartGame_btn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StartGame_btn.ForeColor = SystemColors.Control;
            StartGame_btn.Location = new Point(570, 312);
            StartGame_btn.Name = "StartGame_btn";
            StartGame_btn.Size = new Size(202, 54);
            StartGame_btn.TabIndex = 6;
            StartGame_btn.Text = "New Game";
            StartGame_btn.UseVisualStyleBackColor = false;
            StartGame_btn.Click += StartGame_btn_Click;
            // 
            // Player1Name
            // 
            Player1Name.AutoSize = true;
            Player1Name.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Player1Name.ForeColor = SystemColors.Control;
            Player1Name.Location = new Point(570, 101);
            Player1Name.Name = "Player1Name";
            Player1Name.Size = new Size(116, 29);
            Player1Name.TabIndex = 7;
            Player1Name.Text = "Player1";
            // 
            // Player2Name
            // 
            Player2Name.AutoSize = true;
            Player2Name.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Player2Name.ForeColor = SystemColors.Control;
            Player2Name.Location = new Point(570, 163);
            Player2Name.Name = "Player2Name";
            Player2Name.Size = new Size(116, 29);
            Player2Name.TabIndex = 8;
            Player2Name.Text = "Player1";
            // 
            // Player1Score
            // 
            Player1Score.AutoSize = true;
            Player1Score.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Player1Score.ForeColor = SystemColors.Control;
            Player1Score.Location = new Point(728, 101);
            Player1Score.Name = "Player1Score";
            Player1Score.Size = new Size(28, 29);
            Player1Score.TabIndex = 9;
            Player1Score.Text = "0";
            // 
            // Player2Score
            // 
            Player2Score.AutoSize = true;
            Player2Score.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Player2Score.ForeColor = SystemColors.Control;
            Player2Score.Location = new Point(728, 163);
            Player2Score.Name = "Player2Score";
            Player2Score.Size = new Size(28, 29);
            Player2Score.TabIndex = 10;
            Player2Score.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(570, 396);
            button1.Name = "button1";
            button1.Size = new Size(202, 54);
            button1.TabIndex = 11;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(782, 12);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 12;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Turn_Label
            // 
            Turn_Label.AutoSize = true;
            Turn_Label.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Turn_Label.ForeColor = SystemColors.Control;
            Turn_Label.Location = new Point(256, 12);
            Turn_Label.Name = "Turn_Label";
            Turn_Label.Size = new Size(77, 29);
            Turn_Label.TabIndex = 13;
            Turn_Label.Text = "Turn";
            // 
            // P1Sympol_label
            // 
            P1Sympol_label.AutoSize = true;
            P1Sympol_label.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P1Sympol_label.ForeColor = SystemColors.Control;
            P1Sympol_label.Location = new Point(782, 101);
            P1Sympol_label.Name = "P1Sympol_label";
            P1Sympol_label.Size = new Size(110, 29);
            P1Sympol_label.TabIndex = 14;
            P1Sympol_label.Text = "Symbol";
            // 
            // P2Sympol_label
            // 
            P2Sympol_label.AutoSize = true;
            P2Sympol_label.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P2Sympol_label.ForeColor = SystemColors.Control;
            P2Sympol_label.Location = new Point(782, 163);
            P2Sympol_label.Name = "P2Sympol_label";
            P2Sympol_label.Size = new Size(110, 29);
            P2Sympol_label.TabIndex = 15;
            P2Sympol_label.Text = "Symbol";
            // 
            // SaveScore_btn
            // 
            SaveScore_btn.BackColor = SystemColors.ActiveCaptionText;
            SaveScore_btn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaveScore_btn.ForeColor = SystemColors.Control;
            SaveScore_btn.Location = new Point(570, 487);
            SaveScore_btn.Name = "SaveScore_btn";
            SaveScore_btn.Size = new Size(202, 54);
            SaveScore_btn.TabIndex = 16;
            SaveScore_btn.Text = "Save Score";
            SaveScore_btn.UseVisualStyleBackColor = false;
            SaveScore_btn.Click += SaveScore_btn_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(880, 581);
            Controls.Add(SaveScore_btn);
            Controls.Add(P2Sympol_label);
            Controls.Add(P1Sympol_label);
            Controls.Add(Turn_Label);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Player2Score);
            Controls.Add(Player1Score);
            Controls.Add(Player2Name);
            Controls.Add(Player1Name);
            Controls.Add(StartGame_btn);
            Controls.Add(panel1);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Square9;
        private Button Square8;
        private Button Square7;
        private Button Square6;
        private Button Square5;
        private Button square4;
        private Button Square3;
        private Button Square2;
        private Button Square1;
        private Button StartGame_btn;
        private Label Player1Name;
        private Label Player2Name;
        private Label Player1Score;
        private Label Player2Score;
        private Button button1;
        private Button button2;
        private Label Turn_Label;
        private Label P1Sympol_label;
        private Label P2Sympol_label;
        private Button SaveScore_btn;
    }
}