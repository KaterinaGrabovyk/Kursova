namespace KursovaWinForms
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button5 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            button8 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            button7 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(7, 215);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(906, 396);
            listBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(226, -5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(687, 218);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(679, 177);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ПК";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(606, 128);
            button5.Name = "button5";
            button5.Size = new Size(67, 43);
            button5.TabIndex = 29;
            button5.Text = "OK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(407, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 32);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "HD";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(407, 57);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 32);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "RAM";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(535, 74);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(85, 35);
            numericUpDown1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 16);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 25;
            label1.Text = "Вибір за об'ємом:";
            // 
            // button4
            // 
            button4.Location = new Point(16, 104);
            button4.Name = "button4";
            button4.Size = new Size(313, 65);
            button4.TabIndex = 1;
            button4.Text = "Показати ПК, де є подарунок мишка";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(16, 16);
            button3.Name = "button3";
            button3.Size = new Size(313, 52);
            button3.TabIndex = 0;
            button3.Text = "Впорядкувати за ціною";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button6);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(679, 177);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ноутбуки";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(205, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 171);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Опції";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(71, 124);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(122, 35);
            numericUpDown3.TabIndex = 32;
            numericUpDown3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 126);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 31;
            label3.Text = "ID:";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 131);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 30;
            label2.Text = "%";
            label2.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(398, 115);
            button8.Name = "button8";
            button8.Size = new Size(67, 50);
            button8.TabIndex = 2;
            button8.Text = "ОК";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Acer", "Apple", "Asus", "Dell", "Gigabyte", "HP", "Huawei", "Lenovo", "Microsoft", "MSI", "Raze", "Samsung", "Sony", "Toshiba", "Xiaomi" });
            comboBox1.Location = new Point(138, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 36);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 29;
            comboBox1.Visible = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(236, 124);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(85, 35);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Visible = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(15, 76);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(307, 32);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Використати промокод";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(15, 38);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(285, 32);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Вибір за виробником";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button7
            // 
            button7.Location = new Point(9, 88);
            button7.Name = "button7";
            button7.Size = new Size(190, 58);
            button7.TabIndex = 1;
            button7.Text = "В наявності";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(9, 13);
            button6.Name = "button6";
            button6.Size = new Size(190, 52);
            button6.TabIndex = 0;
            button6.Text = "Всі ноутбуки";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(7, 0);
            button1.Name = "button1";
            button1.Size = new Size(199, 105);
            button1.TabIndex = 0;
            button1.Text = "Показ усіх елементів";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(7, 106);
            button2.Name = "button2";
            button2.Size = new Size(199, 107);
            button2.TabIndex = 1;
            button2.Text = "Зняти всі налаштування";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 628);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(listBox1);
            Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 4, 5, 4);
            Name = "User";
            Text = "User";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private TabControl tabControl1;
        private Button button1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown3;
        private Label label3;
    }
}