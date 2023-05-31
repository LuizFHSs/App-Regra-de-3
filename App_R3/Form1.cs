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
            if (txt_GranC.Text == "")
            {
                lbl_GranC.Text = "C";
            }
            else
            {
                lbl_GranC.Text = txt_GranC.Text;
            }
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
            lbl_GranC.Text = "C";
            lbl_result.Text = "0";
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            bool[] state = { rb_D.Checked, rb_I.Checked };
            Algoritmo _R3 = new();
            
            if(tabControl1.SelectedIndex == 0)
            {
                lbl_result.Text = _R3.Simples(state, txt_value1.Text, txt_value2.Text, txt_value4.Text, txt_value5.Text).ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txt_GranC.Enabled = false;
                lbl_GranC2.Enabled = false;
                lbl_GranC.Enabled = false;
                txt_value3.Enabled = false;
                txt_value6.Enabled = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                txt_GranC.Enabled = false;
                lbl_GranC2.Enabled = false;
                lbl_GranC.Enabled = false;
                txt_value3.Enabled = false;
                txt_value6.Enabled = false;
            }
            else
            {
                txt_value3.Enabled = true;
                txt_value6.Enabled = true;
                txt_GranC.Enabled = true;
                lbl_GranC.Enabled = true;
                lbl_GranC2.Enabled = true;
            }
        }
    }
}