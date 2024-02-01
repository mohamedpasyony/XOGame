namespace XOGame
{
    partial class RegisterOneVsCom
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
            label3 = new Label();
            PName_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            StartGameVScom_btn = new Button();
            close_btn = new Button();
            Game_panel = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            Game_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PName_txt);
            panel1.Location = new Point(280, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 136);
            panel1.TabIndex = 2;
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
            // PName_txt
            // 
            PName_txt.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PName_txt.Location = new Point(22, 93);
            PName_txt.Name = "PName_txt";
            PName_txt.Size = new Size(231, 36);
            PName_txt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(222, 12);
            label1.Name = "label1";
            label1.Size = new Size(386, 68);
            label1.TabIndex = 3;
            label1.Text = "Single Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(280, 186);
            label2.Name = "label2";
            label2.Size = new Size(105, 29);
            label2.TabIndex = 4;
            label2.Text = "Player";
            // 
            // StartGameVScom_btn
            // 
            StartGameVScom_btn.BackColor = SystemColors.ActiveCaptionText;
            StartGameVScom_btn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StartGameVScom_btn.ForeColor = SystemColors.Control;
            StartGameVScom_btn.Location = new Point(323, 420);
            StartGameVScom_btn.Name = "StartGameVScom_btn";
            StartGameVScom_btn.Size = new Size(202, 54);
            StartGameVScom_btn.TabIndex = 6;
            StartGameVScom_btn.Text = "Start Game";
            StartGameVScom_btn.UseVisualStyleBackColor = false;
            StartGameVScom_btn.Click += StartGameVScom_btn_Click;
            // 
            // close_btn
            // 
            close_btn.BackColor = SystemColors.ActiveCaptionText;
            close_btn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            close_btn.ForeColor = SystemColors.Control;
            close_btn.Location = new Point(818, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(50, 50);
            close_btn.TabIndex = 7;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // Game_panel
            // 
            Game_panel.Controls.Add(StartGameVScom_btn);
            Game_panel.Controls.Add(label1);
            Game_panel.Controls.Add(label2);
            Game_panel.Controls.Add(close_btn);
            Game_panel.Controls.Add(panel1);
            Game_panel.Dock = DockStyle.Fill;
            Game_panel.Location = new Point(0, 0);
            Game_panel.Name = "Game_panel";
            Game_panel.Size = new Size(880, 581);
            Game_panel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(22, 15);
            label4.Name = "label4";
            label4.Size = new Size(230, 29);
            label4.TabIndex = 4;
            label4.Text = "You Play With X";
            // 
            // RegisterOneVsCom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(880, 581);
            Controls.Add(Game_panel);
            Name = "RegisterOneVsCom";
            Text = "RegisterOneVsCom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Game_panel.ResumeLayout(false);
            Game_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox PName_txt;
        private Label label1;
        private Label label2;
        private Button StartGameVScom_btn;
        private Button close_btn;
        private Panel Game_panel;
        private Label label4;
    }
}