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
            lbl_GranC.Text = txt_GranC.Text;
            txt_GranA.Clear();
            txt_GranB.Clear();
            txt_GranC.Clear();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_value1.Clear();
            txt_value2.Clear();
            txt_value3.Clear();
            txt_value4.Clear();
            txt_value5.Clear();
            txt_value6.Clear();
            lbl_GranA.Text = "A";
            lbl_GranB.Text = "B";
            lbl_result.Text = "0";
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            Algoritmo_R3 _R3 = new();
            lbl_result.Text = _R3.Simples(rb_simples.Checked, txt_value1.Text, txt_value2.Text, txt_value4.Text, txt_value5.Text).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(rb_simples.Checked)
            {
                txt_GranC.Enabled = false;
            }
            if (!rb_Comp.Checked)
            {
                txt_value3.Enabled = false;
                txt_value6.Enabled = false;
            }
        }

        private void rb_Comp_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Comp.Checked)
            {
                txt_value3.Enabled = true;
                txt_value6.Enabled = true;
                txt_GranC.Enabled = true;
            }
            else
            {
                txt_value3.Enabled = false;
                txt_value6.Enabled = false;
                txt_GranC.Enabled = false;
            }
        }
    }
}