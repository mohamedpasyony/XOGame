namespace XOGame
{
    partial class Scores
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
            Scores_dgv = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Scores_dgv).BeginInit();
            SuspendLayout();
            // 
            // Scores_dgv
            // 
            Scores_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Scores_dgv.BackgroundColor = SystemColors.ControlDarkDark;
            Scores_dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            Scores_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Scores_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Scores_dgv.Location = new Point(209, 100);
            Scores_dgv.Name = "Scores_dgv";
            Scores_dgv.RowHeadersWidth = 51;
            Scores_dgv.RowTemplate.Height = 29;
            Scores_dgv.Size = new Size(758, 391);
            Scores_dgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(389, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 68);
            label1.TabIndex = 1;
            label1.Text = "Scores";
            // 
            // Scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1067, 581);
            Controls.Add(label1);
            Controls.Add(Scores_dgv);
            Name = "Scores";
            Text = "Scores";
            Load += Scores_Load;
            ((System.ComponentModel.ISupportInitialize)Scores_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Scores_dgv;
        private Label label1;
    }
}