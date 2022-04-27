namespace Многоканальная_СМО_с_ожиданием
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTpost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTobsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(18, 43);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество каналов";
            // 
            // textBoxTpost
            // 
            this.textBoxTpost.Location = new System.Drawing.Point(18, 89);
            this.textBoxTpost.Name = "textBoxTpost";
            this.textBoxTpost.Size = new System.Drawing.Size(100, 20);
            this.textBoxTpost.TabIndex = 1;
            this.textBoxTpost.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время поступления заявок (в часах)";
            // 
            // textBoxTobsl
            // 
            this.textBoxTobsl.Location = new System.Drawing.Point(18, 135);
            this.textBoxTobsl.Name = "textBoxTobsl";
            this.textBoxTobsl.Size = new System.Drawing.Size(100, 20);
            this.textBoxTobsl.TabIndex = 2;
            this.textBoxTobsl.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время обслуживания (в часах)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(230, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 342);
            this.listBox1.TabIndex = 3;
            this.listBox1.TabStop = false;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(18, 187);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 20);
            this.textBoxM.TabIndex = 4;
            this.textBoxM.TabStop = false;
            this.textBoxM.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество устройств";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Среднее время пребывания заявки в очереди";
            // 
            // textBoxTq
            // 
            this.textBoxTq.Location = new System.Drawing.Point(21, 432);
            this.textBoxTq.Name = "textBoxTq";
            this.textBoxTq.Size = new System.Drawing.Size(100, 20);
            this.textBoxTq.TabIndex = 4;
            this.textBoxTq.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Среднее число заявок в очереди";
            // 
            // textBoxLq
            // 
            this.textBoxLq.Location = new System.Drawing.Point(21, 353);
            this.textBoxLq.Name = "textBoxLq";
            this.textBoxLq.Size = new System.Drawing.Size(100, 20);
            this.textBoxLq.TabIndex = 4;
            this.textBoxLq.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Среднее число заявок в системе";
            // 
            // textBoxLs
            // 
            this.textBoxLs.Location = new System.Drawing.Point(21, 308);
            this.textBoxLs.Name = "textBoxLs";
            this.textBoxLs.Size = new System.Drawing.Size(100, 20);
            this.textBoxLs.TabIndex = 4;
            this.textBoxLs.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Среднее число заявок в очереди";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Коэффициент использования каналов";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(21, 474);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 20);
            this.textBoxK.TabIndex = 4;
            this.textBoxK.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 523);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxTq);
            this.Controls.Add(this.textBoxLs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxLq);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTpost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTobsl);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Педич 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTpost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTobsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxK;
    }
}

