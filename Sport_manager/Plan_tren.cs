using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sport_manager
{
    public partial class Plan_tren : Form
    {
        public Plan_tren()
        {
            InitializeComponent();
        }

        
        
        

        private void input_Click(object sender, EventArgs e)
        {
            string path = @"D:\kor c#\Sport_manager\Sport_manager\save_files\Plan_tren.txt";

            FileStream fs = new FileStream(path,FileMode.Open);

            StreamWriter sw = new StreamWriter(fs);


            string vibor = "";
            //int[] num_of_day= new int[5];//сделать это вектором
            List<int> num_of_day = new List<int>();
            
            int kol_vo_days = 0;
            if (File.Exists(path))
            {
                
                if (checkBox1.Checked)//считаем номера дней недели
                {
                    kol_vo_days++;
                    num_of_day.Add(1);
                }

                if (checkBox2.Checked)
                {
                    kol_vo_days++;
                    num_of_day.Add(2);
                }

                if (checkBox3.Checked)
                {
                    kol_vo_days++;
                    num_of_day.Add(3);
                }

                if (checkBox4.Checked)
                {
                    kol_vo_days++;
                    num_of_day.Add(4);
                }

                if (checkBox5.Checked)
                {
                    kol_vo_days++;
                    num_of_day.Add(5);
                }

                if (checkBox6.Checked)
                {
                    kol_vo_days++;
                    num_of_day.Add(6);
                }

                sw.WriteLine(kol_vo_days);
                foreach(int k in num_of_day)//Вписываем номера дней недели
                {
                    sw.WriteLine(k);
                }

                if(comboBox1 != null)//Вписываем группы мышц
                {
                    vibor = comboBox1.Text;
                    sw.WriteLine(vibor);
                }
                if (comboBox2 != null)
                {
                    vibor = comboBox2.Text;
                    sw.WriteLine(vibor);
                }
                if (comboBox3 != null)
                {
                    vibor = comboBox3.Text;
                    sw.WriteLine(vibor);
                }
                
            }

            sw.Close();
            fs.Close(); 

            this.Hide();
            Raspsanie rasp = new Raspsanie();
            rasp.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Raspsanie rasp = new Raspsanie();
            rasp.Show();
        }

        Point lastpoint;
        

        private void Plan_tren_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Plan_tren_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Plan_tren_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            { 
                checkBox1.ImageIndex = 1;
                //lk
            }
            else
            {
                checkBox1.ImageIndex = 0;
            }
        }
    }
}
