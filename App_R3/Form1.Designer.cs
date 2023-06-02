namespace App_R3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lbl_GranA = new System.Windows.Forms.Label();
            this.lbl_GranB = new System.Windows.Forms.Label();
            this.btn_AddGran = new System.Windows.Forms.Button();
            this.txt_value1 = new System.Windows.Forms.TextBox();
            this.txt_value2 = new System.Windows.Forms.TextBox();
            this.txt_value4 = new System.Windows.Forms.TextBox();
            this.txt_value5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GranA = new System.Windows.Forms.TextBox();
            this.txt_GranB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GranC = new System.Windows.Forms.TextBox();
            this.lbl_GranC2 = new System.Windows.Forms.Label();
            this.lbl_GranC = new System.Windows.Forms.Label();
            this.txt_value3 = new System.Windows.Forms.TextBox();
            this.txt_value6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rb_I = new System.Windows.Forms.RadioButton();
            this.rb_D = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(374, 260);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 2;
            this.btn_Calc.Text = "CALCULAR";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Limpar.Location = new System.Drawing.Point(0, 320);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(873, 23);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "LIMPAR CAMPOS";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lbl_GranA
            // 
            this.lbl_GranA.AutoSize = true;
            this.lbl_GranA.Location = new System.Drawing.Point(290, 61);
            this.lbl_GranA.Name = "lbl_GranA";
            this.lbl_GranA.Size = new System.Drawing.Size(15, 15);
            this.lbl_GranA.TabIndex = 4;
            this.lbl_GranA.Text = "A";
            // 
            // lbl_GranB
            // 
            this.lbl_GranB.AutoSize = true;
            this.lbl_GranB.Location = new System.Drawing.Point(474, 61);
            this.lbl_GranB.Name = "lbl_GranB";
            this.lbl_GranB.Size = new System.Drawing.Size(14, 15);
            this.lbl_GranB.TabIndex = 5;
            this.lbl_GranB.Text = "B";
            // 
            // btn_AddGran
            // 
            this.btn_AddGran.Location = new System.Drawing.Point(71, 139);
            this.btn_AddGran.Name = "btn_AddGran";
            this.btn_AddGran.Size = new System.Drawing.Size(88, 23);
            this.btn_AddGran.TabIndex = 6;
            this.btn_AddGran.Text = "ADICIONAR";
            this.btn_AddGran.UseVisualStyleBackColor = true;
            this.btn_AddGran.Click += new System.EventHandler(this.btn_AddGran_Click);
            // 
            // txt_value1
            // 
            this.txt_value1.Location = new System.Drawing.Point(290, 96);
            this.txt_value1.Name = "txt_value1";
            this.txt_value1.Size = new System.Drawing.Size(100, 23);
            this.txt_value1.TabIndex = 7;
            // 
            // txt_value2
            // 
            this.txt_value2.Location = new System.Drawing.Point(474, 96);
            this.txt_value2.Name = "txt_value2";
            this.txt_value2.Size = new System.Drawing.Size(100, 23);
            this.txt_value2.TabIndex = 8;
            // 
            // txt_value4
            // 
            this.txt_value4.Location = new System.Drawing.Point(290, 178);
            this.txt_value4.Name = "txt_value4";
            this.txt_value4.Size = new System.Drawing.Size(100, 23);
            this.txt_value4.TabIndex = 9;
            // 
            // txt_value5
            // 
            this.txt_value5.Location = new System.Drawing.Point(474, 178);
            this.txt_value5.Name = "txt_value5";
            this.txt_value5.Size = new System.Drawing.Size(100, 23);
            this.txt_value5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "RESULTADO: ";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(598, 264);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(13, 15);
            this.lbl_result.TabIndex = 13;
            this.lbl_result.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "B";
            // 
            // txt_GranA
            // 
            this.txt_GranA.Location = new System.Drawing.Point(71, 24);
            this.txt_GranA.Name = "txt_GranA";
            this.txt_GranA.Size = new System.Drawing.Size(100, 23);
            this.txt_GranA.TabIndex = 17;
            // 
            // txt_GranB
            // 
            this.txt_GranB.Location = new System.Drawing.Point(71, 62);
            this.txt_GranB.Name = "txt_GranB";
            this.txt_GranB.Size = new System.Drawing.Size(100, 23);
            this.txt_GranB.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_GranC);
            this.groupBox1.Controls.Add(this.lbl_GranC2);
            this.groupBox1.Controls.Add(this.txt_GranA);
            this.groupBox1.Controls.Add(this.txt_GranB);
            this.groupBox1.Controls.Add(this.btn_AddGran);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 179);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADICIONAR NOME DAS GRANDEZAS";
            // 
            // txt_GranC
            // 
            this.txt_GranC.Location = new System.Drawing.Point(71, 100);
            this.txt_GranC.Name = "txt_GranC";
            this.txt_GranC.Size = new System.Drawing.Size(100, 23);
            this.txt_GranC.TabIndex = 25;
            // 
            // lbl_GranC2
            // 
            this.lbl_GranC2.AutoSize = true;
            this.lbl_GranC2.Location = new System.Drawing.Point(51, 103);
            this.lbl_GranC2.Name = "lbl_GranC2";
            this.lbl_GranC2.Size = new System.Drawing.Size(15, 15);
            this.lbl_GranC2.TabIndex = 24;
            this.lbl_GranC2.Text = "C";
            // 
            // lbl_GranC
            // 
            this.lbl_GranC.AutoSize = true;
            this.lbl_GranC.Location = new System.Drawing.Point(653, 61);
            this.lbl_GranC.Name = "lbl_GranC";
            this.lbl_GranC.Size = new System.Drawing.Size(15, 15);
            this.lbl_GranC.TabIndex = 20;
            this.lbl_GranC.Text = "C";
            // 
            // txt_value3
            // 
            this.txt_value3.Location = new System.Drawing.Point(653, 96);
            this.txt_value3.Name = "txt_value3";
            this.txt_value3.Size = new System.Drawing.Size(100, 23);
            this.txt_value3.TabIndex = 21;
            // 
            // txt_value6
            // 
            this.txt_value6.Location = new System.Drawing.Point(653, 178);
            this.txt_value6.Name = "txt_value6";
            this.txt_value6.Size = new System.Drawing.Size(100, 23);
            this.txt_value6.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(596, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "X";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(221, 87);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rb_I);
            this.tabPage1.Controls.Add(this.rb_D);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(213, 59);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simples";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rb_I
            // 
            this.rb_I.AutoSize = true;
            this.rb_I.Location = new System.Drawing.Point(6, 31);
            this.rb_I.Name = "rb_I";
            this.rb_I.Size = new System.Drawing.Size(167, 19);
            this.rb_I.TabIndex = 1;
            this.rb_I.Text = "Inversamente Proporcional";
            this.rb_I.UseVisualStyleBackColor = true;
            // 
            // rb_D
            // 
            this.rb_D.AutoSize = true;
            this.rb_D.Checked = true;
            this.rb_D.Location = new System.Drawing.Point(6, 6);
            this.rb_D.Name = "rb_D";
            this.rb_D.Size = new System.Drawing.Size(161, 19);
            this.rb_D.TabIndex = 0;
            this.rb_D.TabStop = true;
            this.rb_D.Text = "Diretamente Proporcional";
            this.rb_D.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(213, 59);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Composta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_value6);
            this.Controls.Add(this.txt_value3);
            this.Controls.Add(this.lbl_GranC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_value5);
            this.Controls.Add(this.txt_value4);
            this.Controls.Add(this.txt_value2);
            this.Controls.Add(this.txt_value1);
            this.Controls.Add(this.lbl_GranB);
            this.Controls.Add(this.lbl_GranA);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calc);
            this.Name = "Form1";
            this.Text = "Regra de Três";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Calc;
        private Button btn_Limpar;
        private Label lbl_GranA;
        private Label lbl_GranB;
        private Button btn_AddGran;
        private TextBox txt_value1;
        private TextBox txt_value2;
        private TextBox txt_value4;
        private TextBox txt_value5;
        private Label label1;
        private Label label2;
        private Label lbl_result;
        private Label label4;
        private Label label5;
        private TextBox txt_GranA;
        private TextBox txt_GranB;
        private GroupBox groupBox1;
        private Label lbl_GranC;
        private TextBox txt_value3;
        private TextBox txt_value6;
        private Label label6;
        private Label lbl_GranC2;
        private TextBox txt_GranC;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton rb_D;
        private RadioButton rb_I;
    }
}