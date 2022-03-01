using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order
{

    public partial class Form1 : Form
    {
        int total = 0;
        int qty = 1;
        string item;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                qty = int.Parse(textBox1.Text);
            }
            catch
            {
                label3.Text = "";
                MessageBox.Show("請輸入正整數值！", "錯誤訊息", MessageBoxButtons.OK);
                textBox1.Text = "1";
                return;
            }

            if (qty <= 0)
            {
                label3.Text = "";
                MessageBox.Show("不能為負整數值！", "錯誤訊息", MessageBoxButtons.OK);
                textBox1.Text = "1";
                return;
            }

            if (checkBox1.Checked) total = 12500 * qty;
            if (checkBox2.Checked) total = 10500 * qty;
            if (checkBox3.Checked) total = 21900 * qty;
            label3.Text = "你購買 " + item + "" + qty.ToString() + " 台 共計:NT$" + total.ToString("#,#") + "元";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                item = "iPad 2";
                label3.Text = "";
                checkBox1.AutoCheck = false;
                checkBox2.AutoCheck = true;
                checkBox3.AutoCheck = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textBox1.Focus();
                textBox1.Text = "1";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                item = "iPad Mini";
                label3.Text = "";
                checkBox2.AutoCheck = false;
                checkBox1.AutoCheck = true;
                checkBox3.AutoCheck = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                textBox1.Focus();
                textBox1.Text = "1";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                item = "iPhone 5";
                label3.Text = "";
                checkBox3.AutoCheck = false;
                checkBox1.AutoCheck = true;
                checkBox2.AutoCheck = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                textBox1.Focus();
                textBox1.Text = "1";
            }
        }
    }
}
