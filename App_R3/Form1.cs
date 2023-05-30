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
            txt_value1.Clear();
            txt_value2.Clear();
            txt_value3.Clear();
            txt_value4.Clear();
            lbl_GranA.Text = "A";
            lbl_GranB.Text = "B";
            lbl_result.Text = "0";
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
         
        }
    }
}