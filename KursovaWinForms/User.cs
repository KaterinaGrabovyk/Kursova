using KursovaConsole.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaWinForms
{
    public partial class User : Form
    {
        DDBContext dbPC;
        DDBContext2 dbLT;
        public User()
        {
            InitializeComponent();
            dbPC = new DDBContext();
            dbLT = new DDBContext2();
            dbPC.Database.EnsureCreated();
            dbLT.Database.EnsureCreated();

            dbPC.PCs.Load();
            dbLT.LTs.Load();
        }
        //показ
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in dbPC.PCs.Local.ToList())
            { listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Корпус:{item.Korpus},Модель:{item.Model}."); } 
            foreach (var item in dbLT.LTs.Local.ToList())
            { listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Діагональ:{item.Diagonal},Динаміки:{item.Dinamics}."); }
        }
        //Очистити
        private void button2_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            numericUpDown1.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            numericUpDown2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            numericUpDown3.Visible = false;
            numericUpDown3.Value = 0;
            comboBox1.Visible = false;
            listBox1.Items.Clear();
        }
        //---------------ПК----------------
        //За ціною
        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            listBox1.Items.Clear();
            foreach (var item in dbPC.PCs.Local.ToList())
            { listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Корпус:{item.Korpus},Модель:{item.Model}."); }
            listBox1.Sorted = true;
        }
        //Мишка       
        private void button4_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            listBox1.Sorted = false;
            listBox1.Items.Clear();
            foreach (var item in dbPC.PCs.Local.ToList())
            {
                if (item.Price > 40000)
                {
                    listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Корпус:{item.Korpus},Модель:{item.Model}.");
                }
            }
        }
        //За об'ємом
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
            listBox1.Items.Clear();
            if (radioButton1.Checked == true)
            {
                foreach (var item in dbPC.PCs.Local.ToList())
                {
                    if (item.RAM == numericUpDown1.Value)
                    {
                        listBox1.Items.Add($"Об'єм RAM:{item.RAM};Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Корпус:{item.Korpus},Модель:{item.Model}.");
                    }
                }
            }
            if (radioButton2.Checked == true)
            {
                foreach (var item in dbPC.PCs.Local.ToList())
                {
                    if (item.HD == numericUpDown1.Value)
                    {
                        { listBox1.Items.Add($"Об'єм жорского диску:{item.HD};Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Кількість ядер:{item.YadraCount},Корпус:{item.Korpus},Модель:{item.Model}."); }
                    }
                }
            }
        }
        //----------------------------------
        //-----------Ноутбуки---------------
        //Всі
        private void button6_Click(object sender, EventArgs e)
        {            
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            numericUpDown2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            numericUpDown3.Visible = false;
            numericUpDown3.Value = 0;
            comboBox1.Visible = false;
            comboBox1.SelectedItem = null;
            listBox1.Items.Clear();
            foreach (var item in dbLT.LTs.Local.ToList())
            { listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Діагональ:{item.Diagonal},Динаміки:{item.Dinamics}."); }
        }

        //в наявності
        private void button7_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            numericUpDown2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            numericUpDown3.Visible = false;
            numericUpDown3.Value = 0;
            comboBox1.Visible = false;
            comboBox1.SelectedItem = null;
            listBox1.Items.Clear();
            foreach (var item in dbLT.LTs.Local.ToList())
            {
                if (item.isInStock == true)
                {
                    listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Діагональ:{item.Diagonal},Динаміки:{item.Dinamics}.");
                }
            }
        }
        // За промокодом/виробником
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton3.Checked == true)
            {
                foreach (var item in dbLT.LTs.Local.ToList())
                {
                    if (item.Virobnuk == (string)comboBox1.SelectedItem)
                    {
                        listBox1.Items.Add($"Виробник:{item.Virobnuk};Ціна:[{item.Price}]грн;Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Діагональ:{item.Diagonal},Динаміки:{item.Dinamics}.");
                    }
                }
            }
            if (radioButton4.Checked == true)
            {
                if (numericUpDown3.Value == 0)
                {
                    MessageBox.Show("Не обрано позицію");
                }
                else
                {
                    foreach (var item in dbLT.LTs.Local.ToList())
                    {
                        if (item.ID == numericUpDown3.Value)
                        {
                            listBox1.Items.Clear();
                            double zn = (double)numericUpDown2.Value / 100;
                            item.Znijka(zn);
                            listBox1.Items.Add($"Ціна:[{item.Price}]грн,Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount},Діагональ:{item.Diagonal},Динаміки:{item.Dinamics}.");
                            button8.Enabled = false;
                        }
                    }
                }
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button8.Enabled = true;
            comboBox1.Visible = true;
            numericUpDown2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            numericUpDown3.Visible = false;
            foreach (var item in dbLT.LTs.Local.ToList())
            { listBox1.Items.Add($"ID:{item.ID}; Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount};Ціна:[{item.Price}]грн;Діагональ:{item.Diagonal};Динаміки:{item.Dinamics}."); }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            numericUpDown2.Visible = true;
            label2.Visible = true;
            comboBox1.SelectedItem = null;
            label3.Visible = true;
            numericUpDown3.Visible = true;
            listBox1.Items.Clear();
            foreach (var item in dbLT.LTs.Local.ToList())
            { listBox1.Items.Add($"ID:{item.ID}; Виробник:{item.Virobnuk};Об'єм RAM:{item.RAM};Об'єм жорского диску:{item.HD};Кількість ядер:{item.YadraCount};Ціна:[{item.Price}]грн;Діагональ:{item.Diagonal};Динаміки:{item.Dinamics}."); }

        }

        //----------------------------------
    }
}
