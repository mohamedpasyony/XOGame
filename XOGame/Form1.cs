namespace XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        private Form ActiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm_panel.Controls.Add(ChildForm);
            ChildForm_panel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }


        private void Side_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TwoPlayers_btn_Click(object sender, EventArgs e)
        {

        }

        private void GameOptions_btn_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void TwoPlayers_btn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RegisterOneVsone());
        }

        private void SinglePlayer_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterOneVsCom());
        }
        private void ChildForm_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Scores());

        }
    }
}