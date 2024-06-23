using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_manager
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true; 

            foreach (char c in textBox1.Text)
            {
                if (!Char.IsDigit(c))
                {
                    valid = false;
                }
            }
            foreach (char c in textBox2.Text)
            {
                if (!Char.IsDigit(c))
                {
                    valid = false;
                }
            }

            if (valid == false)
            {
                MessageBox.Show("Введите корректные данные");
            }
            else
            {
                int ideal_ves = Convert.ToInt16(textBox1.Text) - 100;
                int realves = Convert.ToInt16(textBox2.Text);
                label2.Text = "Ваш идеальный вес: " + ideal_ves.ToString();
                string path = @"D:\kor c#\Sport_manager\Sport_manager\save_files\vesa.txt";

                if (File.Exists(path))
                {
                    File.WriteAllText(path, textBox2.Text);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Plan_tren plan = new Plan_tren();
            plan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        Point lastpoint;
        private void start_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void start_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
