namespace KursovaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true){ User us = new User();us.ShowDialog(); }
            if (radioButton2.Checked == true)
            {
               /* if (textBox1.Text == "") { MessageBox.Show("Не введено пароль."); }
                else if (textBox1.Text != "123") { MessageBox.Show("Неправильний пароль.");textBox1.Text = ""; }
                else { }*/
                Admin ad = new Admin(); ad.ShowDialog();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible=true;
        }
    }
}
