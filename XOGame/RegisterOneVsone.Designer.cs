namespace XOGame
{
    partial class RegisterOneVsone
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
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            P1Name_txt = new TextBox();
            P1RadioO = new RadioButton();
            P1RadioX = new RadioButton();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            P2Name_txt = new TextBox();
            P2RadioO = new RadioButton();
            P2RadioX = new RadioButton();
            label5 = new Label();
            StartGame_btn = new Button();
            button1 = new Button();
            Game_panel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            Game_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(298, 8);
            label1.Name = "label1";
            label1.Size = new Size(189, 68);
            label1.TabIndex = 0;
            label1.Text = "1 VS 1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(P1Name_txt);
            panel1.Controls.Add(P1RadioO);
            panel1.Controls.Add(P1RadioX);
            panel1.Location = new Point(35, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 136);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(22, 61);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // P1Name_txt
            // 
            P1Name_txt.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P1Name_txt.Location = new Point(22, 93);
            P1Name_txt.Name = "P1Name_txt";
            P1Name_txt.Size = new Size(231, 36);
            P1Name_txt.TabIndex = 2;
            // 
            // P1RadioO
            // 
            P1RadioO.AutoSize = true;
            P1RadioO.BackColor = SystemColors.AppWorkspace;
            P1RadioO.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P1RadioO.ForeColor = SystemColors.Control;
            P1RadioO.Location = new Point(218, 20);
            P1RadioO.Name = "P1RadioO";
            P1RadioO.Size = new Size(52, 33);
            P1RadioO.TabIndex = 1;
            P1RadioO.TabStop = true;
            P1RadioO.Text = "O";
            P1RadioO.UseVisualStyleBackColor = false;
            P1RadioO.CheckedChanged += P1RadioO_CheckedChanged;
            // 
            // P1RadioX
            // 
            P1RadioX.AutoSize = true;
            P1RadioX.BackColor = SystemColors.AppWorkspace;
            P1RadioX.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P1RadioX.ForeColor = SystemColors.Control;
            P1RadioX.Location = new Point(22, 20);
            P1RadioX.Name = "P1RadioX";
            P1RadioX.Size = new Size(52, 33);
            P1RadioX.TabIndex = 0;
            P1RadioX.TabStop = true;
            P1RadioX.Text = "X";
            P1RadioX.UseVisualStyleBackColor = false;
            P1RadioX.CheckedChanged += P1RadioX_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(35, 76);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 2;
            label2.Text = "Player1";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(P2Name_txt);
            panel2.Controls.Add(P2RadioO);
            panel2.Controls.Add(P2RadioX);
            panel2.ForeColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(505, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 136);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(22, 61);
            label4.Name = "label4";
            label4.Size = new Size(77, 29);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // P2Name_txt
            // 
            P2Name_txt.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P2Name_txt.Location = new Point(22, 93);
            P2Name_txt.Name = "P2Name_txt";
            P2Name_txt.Size = new Size(231, 36);
            P2Name_txt.TabIndex = 2;
            // 
            // P2RadioO
            // 
            P2RadioO.AutoSize = true;
            P2RadioO.BackColor = SystemColors.AppWorkspace;
            P2RadioO.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P2RadioO.ForeColor = SystemColors.Control;
            P2RadioO.Location = new Point(218, 20);
            P2RadioO.Name = "P2RadioO";
            P2RadioO.Size = new Size(52, 33);
            P2RadioO.TabIndex = 1;
            P2RadioO.TabStop = true;
            P2RadioO.Text = "O";
            P2RadioO.UseVisualStyleBackColor = false;
            P2RadioO.CheckedChanged += P2RadioO_CheckedChanged;
            // 
            // P2RadioX
            // 
            P2RadioX.AutoSize = true;
            P2RadioX.BackColor = SystemColors.AppWorkspace;
            P2RadioX.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            P2RadioX.ForeColor = SystemColors.Control;
            P2RadioX.Location = new Point(22, 20);
            P2RadioX.Name = "P2RadioX";
            P2RadioX.Size = new Size(52, 33);
            P2RadioX.TabIndex = 0;
            P2RadioX.TabStop = true;
            P2RadioX.Text = "X";
            P2RadioX.UseVisualStyleBackColor = false;
            P2RadioX.CheckedChanged += P2RadioX_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(505, 76);
            label5.Name = "label5";
            label5.Size = new Size(117, 29);
            label5.TabIndex = 4;
            label5.Text = "Player2";
            // 
            // StartGame_btn
            // 
            StartGame_btn.BackColor = SystemColors.ActiveCaptionText;
            StartGame_btn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StartGame_btn.ForeColor = SystemColors.Control;
            StartGame_btn.Location = new Point(324, 323);
            StartGame_btn.Name = "StartGame_btn";
            StartGame_btn.Size = new Size(202, 54);
            StartGame_btn.TabIndex = 5;
            StartGame_btn.Text = "Start Game";
            StartGame_btn.UseVisualStyleBackColor = false;
            StartGame_btn.Click += StartGame_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(822, 8);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Game_panel
            // 
            Game_panel.BackColor = SystemColors.ActiveCaptionText;
            Game_panel.Controls.Add(StartGame_btn);
            Game_panel.Controls.Add(label1);
            Game_panel.Controls.Add(button1);
            Game_panel.Controls.Add(panel2);
            Game_panel.Controls.Add(label2);
            Game_panel.Controls.Add(label5);
            Game_panel.Controls.Add(panel1);
            Game_panel.Dock = DockStyle.Fill;
            Game_panel.Location = new Point(0, 0);
            Game_panel.Name = "Game_panel";
            Game_panel.Size = new Size(898, 628);
            Game_panel.TabIndex = 7;
            // 
            // RegisterOneVsone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(898, 628);
            Controls.Add(Game_panel);
            Name = "RegisterOneVsone";
            Text = "RegisterOneVsone";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Game_panel.ResumeLayout(false);
            Game_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RadioButton P1RadioO;
        private RadioButton P1RadioX;
        private Label label2;
        private Label label3;
        private TextBox P1Name_txt;
        private Panel panel2;
        private Label label4;
        private TextBox P2Name_txt;
        private RadioButton P2RadioO;
        private RadioButton P2RadioX;
        private Label label5;
        private Button StartGame_btn;
        private Button button1;
        private Panel Game_panel;
    }
}