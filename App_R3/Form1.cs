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
            cb_Confirm1.Checked = false;
            cb_Confirm2.Checked = false;
            cb_Confirm1.Text = "";
            cb_Confirm2.Text = "";
            cb_Confirm1.Hide();
            cb_Confirm2.Hide();
            lbl_GranA.Text = "A";
            lbl_GranB.Text = "B";
            lbl_GranC.Text = "C";
            lbl_result.Text = "0";
            lbl_stats.Show();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            bool[] stateS = { rb_D.Checked, rb_I.Checked };
            bool[] stateC = { cb_Confirm1.Checked, cb_Confirm2.Checked };

            Algoritmo _R3 = new();
            
            if(tabControl1.SelectedIndex == 0)
            {
                lbl_result.Text = _R3.Simples(stateS, txt_value1.Text, txt_value2.Text, txt_value4.Text, txt_value5.Text).ToString();
            }
            else
            {
                lbl_result.Text = _R3.Composta(stateC, txt_value1.Text, txt_value2.Text, txt_value3.Text, txt_value4.Text, txt_value5.Text, txt_value6.Text).ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Confirm1.Hide();
            cb_Confirm2.Hide();
            lbl_stats.Text = "AGUARDANDO INFORMAÇÕES...";

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

        private void txt_value4_TextChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                if (txt_value4.Text == "x")
                {
                    lbl_stats.Hide();
                    cb_Confirm1.Show();
                    cb_Confirm1.Text = lbl_GranA.Text + " é diretamente proprocional a " + lbl_GranB.Text + ".";
                    cb_Confirm2.Show();
                    cb_Confirm2.Text = lbl_GranA.Text + " é diretamente proprocional a " + lbl_GranC.Text + ".";
                }
            }
            
        }

        private void txt_value5_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txt_value5.Text == "x")
                {
                    lbl_stats.Hide();
                    cb_Confirm1.Show();
                    cb_Confirm1.Text = lbl_GranB.Text + " é diretamente proprocional a " + lbl_GranA.Text + ".";
                    cb_Confirm2.Show();
                    cb_Confirm2.Text = lbl_GranB.Text + " é diretamente proprocional a " + lbl_GranC.Text + ".";
                }
            }
        }

        private void txt_value6_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txt_value6.Text == "x")
                {
                    lbl_stats.Hide();
                    cb_Confirm1.Show();
                    cb_Confirm1.Text = lbl_GranC.Text + " é diretamente proprocional a " + lbl_GranA.Text + ".";
                    cb_Confirm2.Show();
                    cb_Confirm2.Text = lbl_GranC.Text + " é diretamente proprocional a " + lbl_GranB.Text + ".";
                }
            }
        }
    }
}