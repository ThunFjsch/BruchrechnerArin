namespace burchrechnerArin
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstInteger = new System.Windows.Forms.TextBox();
            this.counterOne = new System.Windows.Forms.TextBox();
            this.firstDenominator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondDenominator = new System.Windows.Forms.TextBox();
            this.secondConter = new System.Windows.Forms.TextBox();
            this.secondInteger = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.RadioButton();
            this.times = new System.Windows.Forms.RadioButton();
            this.carrotTwo = new System.Windows.Forms.RadioButton();
            this.root = new System.Windows.Forms.RadioButton();
            this.divide = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.fRDenominator = new System.Windows.Forms.TextBox();
            this.FRCounter = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sRDenominator = new System.Windows.Forms.TextBox();
            this.sRCounter = new System.Windows.Forms.TextBox();
            this.sRInteger = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstInteger
            // 
            this.firstInteger.BackColor = System.Drawing.Color.SkyBlue;
            this.firstInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firstInteger.Location = new System.Drawing.Point(43, 85);
            this.firstInteger.Name = "firstInteger";
            this.firstInteger.Size = new System.Drawing.Size(120, 29);
            this.firstInteger.TabIndex = 0;
            this.firstInteger.Text = "0";
            this.firstInteger.TextChanged += new System.EventHandler(this.firstInteger_TextChanged);
            // 
            // counterOne
            // 
            this.counterOne.BackColor = System.Drawing.Color.SkyBlue;
            this.counterOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.counterOne.Location = new System.Drawing.Point(181, 61);
            this.counterOne.Name = "counterOne";
            this.counterOne.Size = new System.Drawing.Size(120, 29);
            this.counterOne.TabIndex = 1;
            this.counterOne.Text = "0";
            // 
            // firstDenominator
            // 
            this.firstDenominator.BackColor = System.Drawing.Color.SkyBlue;
            this.firstDenominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firstDenominator.Location = new System.Drawing.Point(181, 115);
            this.firstDenominator.Name = "firstDenominator";
            this.firstDenominator.Size = new System.Drawing.Size(120, 29);
            this.firstDenominator.TabIndex = 2;
            this.firstDenominator.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(169, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "----------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(687, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "----------------------------";
            // 
            // secondDenominator
            // 
            this.secondDenominator.BackColor = System.Drawing.Color.SkyBlue;
            this.secondDenominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.secondDenominator.Location = new System.Drawing.Point(699, 114);
            this.secondDenominator.Name = "secondDenominator";
            this.secondDenominator.Size = new System.Drawing.Size(120, 29);
            this.secondDenominator.TabIndex = 6;
            this.secondDenominator.Text = "0";
            // 
            // secondConter
            // 
            this.secondConter.BackColor = System.Drawing.Color.SkyBlue;
            this.secondConter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.secondConter.Location = new System.Drawing.Point(699, 60);
            this.secondConter.Name = "secondConter";
            this.secondConter.Size = new System.Drawing.Size(120, 29);
            this.secondConter.TabIndex = 5;
            this.secondConter.Text = "0";
            // 
            // secondInteger
            // 
            this.secondInteger.BackColor = System.Drawing.Color.SkyBlue;
            this.secondInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.secondInteger.Location = new System.Drawing.Point(561, 84);
            this.secondInteger.Name = "secondInteger";
            this.secondInteger.Size = new System.Drawing.Size(120, 29);
            this.secondInteger.TabIndex = 4;
            this.secondInteger.Text = "0";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.plus.Location = new System.Drawing.Point(378, 64);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(39, 28);
            this.plus.TabIndex = 8;
            this.plus.TabStop = true;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // times
            // 
            this.times.AutoSize = true;
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.times.Location = new System.Drawing.Point(378, 87);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(35, 28);
            this.times.TabIndex = 9;
            this.times.TabStop = true;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            // 
            // carrotTwo
            // 
            this.carrotTwo.AutoSize = true;
            this.carrotTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.carrotTwo.Location = new System.Drawing.Point(378, 110);
            this.carrotTwo.Name = "carrotTwo";
            this.carrotTwo.Size = new System.Drawing.Size(43, 28);
            this.carrotTwo.TabIndex = 10;
            this.carrotTwo.TabStop = true;
            this.carrotTwo.Text = "x²";
            this.carrotTwo.UseVisualStyleBackColor = true;
            // 
            // root
            // 
            this.root.AutoSize = true;
            this.root.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.root.Location = new System.Drawing.Point(449, 110);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(38, 28);
            this.root.TabIndex = 13;
            this.root.TabStop = true;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.divide.Location = new System.Drawing.Point(449, 87);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(33, 28);
            this.divide.TabIndex = 12;
            this.divide.TabStop = true;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.minus.Location = new System.Drawing.Point(449, 64);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(34, 28);
            this.minus.TabIndex = 11;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(319, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "----------------------------";
            // 
            // fRDenominator
            // 
            this.fRDenominator.BackColor = System.Drawing.Color.SkyBlue;
            this.fRDenominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fRDenominator.Location = new System.Drawing.Point(331, 312);
            this.fRDenominator.Name = "fRDenominator";
            this.fRDenominator.ReadOnly = true;
            this.fRDenominator.Size = new System.Drawing.Size(120, 29);
            this.fRDenominator.TabIndex = 16;
            // 
            // FRCounter
            // 
            this.FRCounter.BackColor = System.Drawing.Color.SkyBlue;
            this.FRCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FRCounter.Location = new System.Drawing.Point(331, 258);
            this.FRCounter.Name = "FRCounter";
            this.FRCounter.ReadOnly = true;
            this.FRCounter.Size = new System.Drawing.Size(120, 29);
            this.FRCounter.TabIndex = 15;
            this.FRCounter.TextChanged += new System.EventHandler(this.FRCounter_TextChanged);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(43, 175);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(97, 237);
            this.btn_calc.TabIndex = 18;
            this.btn_calc.Text = "Berechne";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(678, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "----------------------------";
            // 
            // sRDenominator
            // 
            this.sRDenominator.BackColor = System.Drawing.Color.SkyBlue;
            this.sRDenominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sRDenominator.Location = new System.Drawing.Point(690, 312);
            this.sRDenominator.Name = "sRDenominator";
            this.sRDenominator.ReadOnly = true;
            this.sRDenominator.Size = new System.Drawing.Size(120, 29);
            this.sRDenominator.TabIndex = 21;
            // 
            // sRCounter
            // 
            this.sRCounter.BackColor = System.Drawing.Color.SkyBlue;
            this.sRCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sRCounter.Location = new System.Drawing.Point(690, 258);
            this.sRCounter.Name = "sRCounter";
            this.sRCounter.ReadOnly = true;
            this.sRCounter.Size = new System.Drawing.Size(120, 29);
            this.sRCounter.TabIndex = 20;
            // 
            // sRInteger
            // 
            this.sRInteger.BackColor = System.Drawing.Color.SkyBlue;
            this.sRInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sRInteger.Location = new System.Drawing.Point(552, 282);
            this.sRInteger.Name = "sRInteger";
            this.sRInteger.ReadOnly = true;
            this.sRInteger.Size = new System.Drawing.Size(120, 29);
            this.sRInteger.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(473, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(751, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(643, 415);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 25;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(552, 415);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sRDenominator);
            this.Controls.Add(this.sRCounter);
            this.Controls.Add(this.sRInteger);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fRDenominator);
            this.Controls.Add(this.FRCounter);
            this.Controls.Add(this.root);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.carrotTwo);
            this.Controls.Add(this.times);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondDenominator);
            this.Controls.Add(this.secondConter);
            this.Controls.Add(this.secondInteger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstDenominator);
            this.Controls.Add(this.counterOne);
            this.Controls.Add(this.firstInteger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstInteger;
        private System.Windows.Forms.TextBox counterOne;
        private System.Windows.Forms.TextBox firstDenominator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondDenominator;
        private System.Windows.Forms.TextBox secondConter;
        private System.Windows.Forms.TextBox secondInteger;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton times;
        private System.Windows.Forms.RadioButton carrotTwo;
        private System.Windows.Forms.RadioButton root;
        private System.Windows.Forms.RadioButton divide;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fRDenominator;
        private System.Windows.Forms.TextBox FRCounter;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sRDenominator;
        private System.Windows.Forms.TextBox sRCounter;
        private System.Windows.Forms.TextBox sRInteger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_clear;
    }
}

