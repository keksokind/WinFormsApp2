namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { lbl5.Text = "Meissa"; lbl5.Refresh(); }
            { lbl4.Text = "Alnilam"; lbl4.Refresh(); }
            { lbl.Text = "Mintaka"; lbl.Refresh(); }
            { lbl7.Text = "Rigel"; lbl7.Refresh(); }
            { lbl3.Text = "Saiph"; lbl3.Refresh(); }
            { lbl1.Text = "Betelgeuse"; lbl4.Refresh(); }
            { lbl2.Text = "Altitak"; lbl2.Refresh(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            { lbl5.Text = " "; lbl5.Refresh(); }
            { lbl4.Text = " "; lbl4.Refresh(); }
            { lbl.Text = " "; lbl.Refresh(); }
            { lbl7.Text = " "; lbl7.Refresh(); }
            { lbl3.Text = " "; lbl3.Refresh(); }
            { lbl1.Text = " "; lbl1.Refresh(); }
            { lbl2.Text = " "; lbl2.Refresh(); }
        }

        private void lbl5_Click(object sender, EventArgs e)
        {    
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Click(object sender, EventArgs e)
        {
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
        }
    }
}
