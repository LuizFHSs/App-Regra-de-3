namespace App_R3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddGran_Click(object sender, EventArgs e)
        {
            lbl_GranA.Text = txt_GranA.Text;
            lbl_GranB.Text = txt_GranB.Text;
            txt_GranA.Clear();
            txt_GranB.Clear();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }
    }
}