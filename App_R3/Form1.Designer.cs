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
            this.rb_simples = new System.Windows.Forms.RadioButton();
            this.rb_Comp = new System.Windows.Forms.RadioButton();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lbl_GranA = new System.Windows.Forms.Label();
            this.lbl_GranB = new System.Windows.Forms.Label();
            this.btn_AddGran = new System.Windows.Forms.Button();
            this.txt_value1 = new System.Windows.Forms.TextBox();
            this.txt_value2 = new System.Windows.Forms.TextBox();
            this.txt_value3 = new System.Windows.Forms.TextBox();
            this.txt_value4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GranA = new System.Windows.Forms.TextBox();
            this.txt_GranB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_simples
            // 
            this.rb_simples.AutoSize = true;
            this.rb_simples.Location = new System.Drawing.Point(12, 20);
            this.rb_simples.Name = "rb_simples";
            this.rb_simples.Size = new System.Drawing.Size(136, 19);
            this.rb_simples.TabIndex = 0;
            this.rb_simples.TabStop = true;
            this.rb_simples.Text = "Regra de três simples";
            this.rb_simples.UseVisualStyleBackColor = true;
            // 
            // rb_Comp
            // 
            this.rb_Comp.AutoSize = true;
            this.rb_Comp.Location = new System.Drawing.Point(154, 20);
            this.rb_Comp.Name = "rb_Comp";
            this.rb_Comp.Size = new System.Drawing.Size(149, 19);
            this.rb_Comp.TabIndex = 1;
            this.rb_Comp.TabStop = true;
            this.rb_Comp.Text = "Regra de três composta";
            this.rb_Comp.UseVisualStyleBackColor = true;
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(374, 200);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 2;
            this.btn_Calc.Text = "CALCULAR";
            this.btn_Calc.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Limpar.Location = new System.Drawing.Point(0, 244);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(670, 23);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "LIMPAR CAMPOS";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lbl_GranA
            // 
            this.lbl_GranA.AutoSize = true;
            this.lbl_GranA.Location = new System.Drawing.Point(374, 19);
            this.lbl_GranA.Name = "lbl_GranA";
            this.lbl_GranA.Size = new System.Drawing.Size(15, 15);
            this.lbl_GranA.TabIndex = 4;
            this.lbl_GranA.Text = "A";
            // 
            // lbl_GranB
            // 
            this.lbl_GranB.AutoSize = true;
            this.lbl_GranB.Location = new System.Drawing.Point(558, 19);
            this.lbl_GranB.Name = "lbl_GranB";
            this.lbl_GranB.Size = new System.Drawing.Size(14, 15);
            this.lbl_GranB.TabIndex = 5;
            this.lbl_GranB.Text = "B";
            // 
            // btn_AddGran
            // 
            this.btn_AddGran.Location = new System.Drawing.Point(71, 106);
            this.btn_AddGran.Name = "btn_AddGran";
            this.btn_AddGran.Size = new System.Drawing.Size(88, 23);
            this.btn_AddGran.TabIndex = 6;
            this.btn_AddGran.Text = "ADICIONAR";
            this.btn_AddGran.UseVisualStyleBackColor = true;
            this.btn_AddGran.Click += new System.EventHandler(this.btn_AddGran_Click);
            // 
            // txt_value1
            // 
            this.txt_value1.Location = new System.Drawing.Point(374, 54);
            this.txt_value1.Name = "txt_value1";
            this.txt_value1.Size = new System.Drawing.Size(100, 23);
            this.txt_value1.TabIndex = 7;
            // 
            // txt_value2
            // 
            this.txt_value2.Location = new System.Drawing.Point(558, 54);
            this.txt_value2.Name = "txt_value2";
            this.txt_value2.Size = new System.Drawing.Size(100, 23);
            this.txt_value2.TabIndex = 8;
            // 
            // txt_value3
            // 
            this.txt_value3.Location = new System.Drawing.Point(374, 136);
            this.txt_value3.Name = "txt_value3";
            this.txt_value3.Size = new System.Drawing.Size(100, 23);
            this.txt_value3.TabIndex = 9;
            // 
            // txt_value4
            // 
            this.txt_value4.Location = new System.Drawing.Point(558, 136);
            this.txt_value4.Name = "txt_value4";
            this.txt_value4.Size = new System.Drawing.Size(100, 23);
            this.txt_value4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(491, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "RESULTADO: ";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(597, 204);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(13, 15);
            this.lbl_result.TabIndex = 13;
            this.lbl_result.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 27);
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
            this.groupBox1.Controls.Add(this.txt_GranA);
            this.groupBox1.Controls.Add(this.txt_GranB);
            this.groupBox1.Controls.Add(this.btn_AddGran);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 150);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADICIONAR NOME DAS GRANDEZAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_value4);
            this.Controls.Add(this.txt_value3);
            this.Controls.Add(this.txt_value2);
            this.Controls.Add(this.txt_value1);
            this.Controls.Add(this.lbl_GranB);
            this.Controls.Add(this.lbl_GranA);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.rb_Comp);
            this.Controls.Add(this.rb_simples);
            this.Name = "Form1";
            this.Text = "Regra de Três";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rb_simples;
        private RadioButton rb_Comp;
        private Button btn_Calc;
        private Button btn_Limpar;
        private Label lbl_GranA;
        private Label lbl_GranB;
        private Button btn_AddGran;
        private TextBox txt_value1;
        private TextBox txt_value2;
        private TextBox txt_value3;
        private TextBox txt_value4;
        private Label label1;
        private Label label2;
        private Label lbl_result;
        private Label label4;
        private Label label5;
        private TextBox txt_GranA;
        private TextBox txt_GranB;
        private GroupBox groupBox1;
    }
}