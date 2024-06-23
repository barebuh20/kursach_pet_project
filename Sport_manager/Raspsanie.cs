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
    public partial class Raspsanie : Form
    {
        public Raspsanie()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint;
        private void Raspsanie_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Raspsanie_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Raspsanie_Load(object sender, EventArgs e)
        {
            displadays();
        }

        public void displadays()
        {
            DateTime now = DateTime.Now;
            DateTime startOfTheMonth = new DateTime(now.Year,now.Month,1);

            int days = DateTime.DaysInMonth(now.Year,now.Month);

            int dayOftheweek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) ;

            for (int i = 1; i < dayOftheweek; i++)
            {
                Userfordays ufdays = new Userfordays(); 
                daycontainer.Controls.Add(ufdays);
            }

            int j = 0;
            string path3 = @"D:\kor c#\Sport_manager\Sport_manager\save_files\j.txt";
            FileStream fs2 = new FileStream(path3, FileMode.Open);
            StreamWriter sw2 = new StreamWriter(fs2);
            sw2.WriteLine(j);
            sw2.Close();
            fs2.Close();

            for (int i = 1;i <= days; i++)
            {
                daysany ufdays2 = new daysany();
                ufdays2.days(i);
                ufdays2.upr(i,dayOftheweek);
                daycontainer.Controls.Add(ufdays2);
            }
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
