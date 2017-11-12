using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace coffee_pos_603410194_3
{
    public partial class Form1 : Form
    {
        int i = 0, j = 1;
        double total;
        string[] no = new string[50];
        string[] m = new string[50];
        string[] n = new string[50];
        string aaaaa;
        public Form1()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            tb_total.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Esspresso (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Esspresso (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Esspresso (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Americano (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Americano (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Latte (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Latte (Ice)";
            n[i] = "45";
            list();
            i++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Latte (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Mocha (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Mocha (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Mocha (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Cappuccino (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Cappuccino (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Cappuccino (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "GreenTea (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "GreenTae (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "GreenTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "ThaiTea (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "ThaiTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "ThaiTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "CoCao (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "CoCao (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "CoCao (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milk (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milk (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milk (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "MilkTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "MilkTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "LemonTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "LemonTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milo (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milo (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milo (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesCafe (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesCafe (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesCafe (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesteaTae (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesteaTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesteaTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Italian Soda (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Red lime Soda (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Honey lime Soda (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            i = 0;
            tb_total.Text = "0";
            total = 0;
            listView_top.Items.Clear();
        }

        public void list()
        {
            ListViewItem bass = new ListViewItem();
            bass.Text = no[i];
            bass.SubItems.Add(m[i]);
            bass.SubItems.Add(n[i]);
            listView_top.Items.Add(bass);
        }

        private void listView_top_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button45_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tb_total.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูที่ต้องการ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("ต้องการทำรายการใช่หรือไม่", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            i = 0;
            tb_total.Text = "0";
            listView_top.Items.Clear();
            total = 0;
            File.WriteAllText("Bass" + (j) + ".txt", aaaaa);
            j++;
        }

        private void tb_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Esspresso (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Esspresso (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Americano (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Americano (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Latte (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Latte (Ice)";
            n[i] = "45";
            list();
            i++;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Latte (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Mocha (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Mocha (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Mocha (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            total += 35;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Cappuccino (Hot)";
            n[i] = "35";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            total += 45;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Cappuccino (Ice)";
            n[i] = "45";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            total += 50;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Cappuccino (Frappe)";
            n[i] = "50";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "GreenTea (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "GreenTae (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "GreenTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "ThaiTea (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "ThaiTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "ThaiTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "CoCao (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "CoCao (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "CoCao (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milk (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milk (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milk (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "MilkTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "MilkTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "LemonTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "LemonTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milo (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milo (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Milo (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesCafe (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesCafe (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesCafe (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            total += 20;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesteaTae (Hot)";
            n[i] = "20";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesteaTea (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            total += 30;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "NesteaTea (Frappe)";
            n[i] = "30";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Italian Soda (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Red lime Soda (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            total += 25;
            tb_total.Text = total.ToString() + ".00 THB";
            no[i] = (i + 1).ToString() + ".";
            m[i] = "Honey lime Soda (Ice)";
            n[i] = "25";
            aaaaa += m[i] + "     " + n[i] + Environment.NewLine;
            list();
            i++;
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            i = 0;
            tb_total.Text = "0";
            total = 0;
            listView_top.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb_total.Text == "")
            {
                MessageBox.Show("เลือกเมนูที่ต้องการ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MessageBox.Show("Ok", "ยืนยัน!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            i = 0;
            tb_total.Text = "0";
            listView_top.Items.Clear();
            total = 0;
            File.WriteAllText("bass" + (j) + ".txt", aaaaa);
            j++;
        }

    
    }
}
