using KursovaConsole.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaWinForms
{
    public partial class Admin : Form
    {
        DDBContext dbPC;
        DDBContext2 dbLT;
        public Admin()
        {
            InitializeComponent();
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Scrollable = true;
            listView1.MultiSelect = false;
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Ціна", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Є на складі", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Виробник", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("RAM", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("HD", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Кількість ядер", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Корпус", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Модель", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Діагональ", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Динаміки", 200, HorizontalAlignment.Center);

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
            listView1.Items.Clear();
            foreach (var itemPC in dbPC.PCs.Local.ToList())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = "" + itemPC.ID;
                item.SubItems.Add((itemPC.Price).ToString());
                item.SubItems.Add((itemPC.isInStock).ToString());
                item.SubItems.Add(itemPC.Virobnuk);
                item.SubItems.Add((itemPC.RAM).ToString());
                item.SubItems.Add((itemPC.HD).ToString());
                item.SubItems.Add((itemPC.YadraCount).ToString());
                item.SubItems.Add(itemPC.Korpus);
                item.SubItems.Add(itemPC.Model);
                listView1.Items.Add(item);
            }
            foreach (var itemLT in dbLT.LTs.Local.ToList())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = "" + itemLT.ID;
                item.SubItems.Add((itemLT.Price).ToString());
                item.SubItems.Add((itemLT.isInStock).ToString());
                item.SubItems.Add(itemLT.Virobnuk);
                item.SubItems.Add((itemLT.RAM).ToString());
                item.SubItems.Add((itemLT.HD).ToString());
                item.SubItems.Add((itemLT.YadraCount).ToString());
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add((itemLT.Diagonal).ToString());
                item.SubItems.Add(itemLT.Dinamics);
                listView1.Items.Add(item);
            }
        }
        //редагувати
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                foreach (var itemP in dbPC.PCs.Local.ToList())
                {
                    if (itemP.ID == numericUpDown7.Value)
                    {
                        itemP.Price = (double)numericUpDown8.Value;
                        DialogResult res = MessageBox.Show("Ви впевнені що хочете змінити ціну?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes) { MessageBox.Show("Оновлено"); dbPC.SaveChanges(); }
                    }                   
                }
            }
            if (radioButton7.Checked == true)
            {
                foreach (var itemL in dbLT.LTs.Local.ToList())
                {
                    if (itemL.ID == numericUpDown7.Value)
                    {
                        itemL.Price = (double)numericUpDown8.Value;
                        DialogResult res = MessageBox.Show("Ви впевнені що хочете змінити ціну?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes) { MessageBox.Show("Оновлено"); dbLT.SaveChanges(); }
                    }
                }
            }
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 1;
        }
        private void Clean()
        {
            
            comboBox1.SelectedItem = null;
            numericUpDown5.Value = 11;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 10000;
            numericUpDown5.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            textBox2.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }
        //видалити
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                foreach (var itemP in dbPC.PCs.Local.ToList())
                {
                    if (itemP.ID == numericUpDown6.Value)
                    {
                        dbPC.Remove(itemP);
                        DialogResult res = MessageBox.Show("Ви впевнені що хочете видалити?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes) { MessageBox.Show("Видалено"); dbPC.SaveChanges();  }
                    }

                }
            }
            if (radioButton5.Checked == true)
            {
                foreach (var itemL in dbLT.LTs.Local.ToList())
                {
                    if (itemL.ID == numericUpDown6.Value)
                    {
                        dbPC.Remove(itemL);
                        DialogResult res = MessageBox.Show("Ви впевнені що хочете видалити?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes) {
                            MessageBox.Show("Видалено"); dbLT.SaveChanges(); }
                    }
                }
            }
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            numericUpDown6.Value = 0;
        }
        //додати
        private void button6_Click(object sender, EventArgs e)
        {
            bool isStock;
            if (comboBox1.SelectedItem != null
                && (radioButton1.Checked == true || radioButton2.Checked == true)
                && (radioButton3.Checked == true || radioButton4.Checked == true))
            {
                if (radioButton1.Checked == true) { isStock = true; }
                else { isStock = false; }
                if (radioButton3.Checked == true)
                {
                    if (comboBox4.SelectedItem == null || textBox2.Text == "")
                    { MessageBox.Show("Не введено дані."); }
                    else
                    {
                        dbPC.Add(new PC((string)comboBox1.SelectedItem, (int)numericUpDown1.Value,
                            (int)numericUpDown2.Value, (int)numericUpDown3.Value, (double)numericUpDown4.Value,
                            isStock, textBox2.Text, (string)comboBox4.SelectedItem)); dbPC.SaveChanges();
                        MessageBox.Show("Додано. Поля будуть очищенні.");
                        Clean();
                    }
                }
                else
                {
                    if (comboBox3.SelectedItem == null)
                    { MessageBox.Show("Не введено дані."); }
                    else
                    {
                        dbLT.Add(new LapTop((string)comboBox1.SelectedItem, (int)numericUpDown1.Value,
                            (int)numericUpDown2.Value, (int)numericUpDown3.Value, (double)numericUpDown4.Value,
                            isStock, (double)numericUpDown5.Value, (string)comboBox3.SelectedItem)); dbLT.SaveChanges();
                        MessageBox.Show("Додано. Поля будуть очищенні.");
                        Clean();
                    }
                }
            }
            else
            {
                MessageBox.Show("Необрано варіанти.");
            }           
        }
        //очистити
        private void button5_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "Корпус";
            label7.Visible = true;
            label7.Text = "Модель";
            comboBox4.Visible = true;
            textBox2.Visible = true;
            numericUpDown5.Visible = false;
            comboBox3.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Visible = false;
            textBox2.Visible = false;
            label6.Visible = true;
            label6.Text = "Діагональ";
            label7.Visible = true;
            label7.Text = "Динаміки";
            numericUpDown5.Visible = true;
            comboBox3.Visible = true;
        }
    }
}
