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
            Algoritmo_R3 _R3 = new();
            lbl_result.Text = _R3.Simples(rb_simples.Checked, txt_value1.Text, txt_value2.Text, txt_value3.Text, txt_value4.Text).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!rb_Comp.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void rb_Comp_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Comp.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }
    }
}