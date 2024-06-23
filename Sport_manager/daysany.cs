using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_manager
{
    public partial class daysany : UserControl
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();


        public daysany()
        {
            InitializeComponent();
        }

        private void dayslb_Load(object sender, EventArgs e)
        {
            
        }

        public void upr(int dd,int shit)// прописываем упражнения в дни недели
        {
            Win32.AllocConsole();
            string path = @"D:\kor c#\Sport_manager\Sport_manager\save_files\Plan_tren.txt";
            string path2 = @"D:\kor c#\Sport_manager\Sport_manager\save_files\j.txt";
            string path3 = @"D:\kor c#\Sport_manager\Sport_manager\save_files\j.txt";

            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sw = new StreamReader(fs);

            int kolvo = Convert.ToInt32(sw.ReadLine());

            int[] dayweek = new int[7];

            for (int i = 0; i < dayweek.Length; i++)
            {
                dayweek[i] = 0;
            }

            int k = 0;
            for (int i = 0; i < kolvo; i++)// записываю в соответствующую ячейку массива номер дня недели из файла
            {
                k = Convert.ToInt32(sw.ReadLine());
                dayweek[k] = k;
                
            }

            DateTime now = DateTime.Now;
            DateTime dennedeli = new DateTime(now.Year, now.Month, dd);

            string uprs = "";
            for (int i = 0; i < 3; i++)
            {
                uprs += sw.ReadLine();
                uprs += " ";
            }
            string[] nums = uprs.Split(' ');// создаю массив каждый элемент которого это упражнение выбранное пользователем
            
            int j = 0;// Эта переменная нужна для сдвига дня недели на первое число
           
            FileStream fs3 = new FileStream(path3, FileMode.Open);
            StreamReader sw3 = new StreamReader(fs3);
            j = Convert.ToInt32(sw3.ReadLine());
            sw3.Close();
            fs3.Close();
            
            for (int i = 0; i < dayweek.Length; i++)// вписываем упражнения в ячеку календаря,                                  
            {                                       // и прокручиваем их список с помощью j
                Console.WriteLine("dd="+dd);
                Console.WriteLine(Convert.ToInt32(dennedeli.DayOfWeek));
                if (j >= 3)
                {
                    j = 0;
                }
                
                if (dayweek[i] == Convert.ToInt32(dennedeli.DayOfWeek) && dayweek[i] != 0)
                {
                    
                    lb_uprazhnenie.Text = nums[j];
                    j++;
                }
                
                if (j >= 3)
                {
                    j = 0;
                }
            }

            FileStream fs2 = new FileStream(path2, FileMode.Open);
            StreamWriter sw2 = new StreamWriter(fs2);
            sw2.WriteLine(j);
            sw2.Close();
            fs2.Close();

            sw.Close();
            fs.Close();
             
        }

        public void days(int numdays)// прописываем чсла и выделяем сегодняшнее
        {
            lbdays.Text = numdays.ToString()+"";
            DateTime now = DateTime.Now;
            if (now.Day == numdays)
            {
                lbdays.BackColor = Color.Blue;
            }
        }

        private void lb_uprazhnenie_Click(object sender, EventArgs e)
        {

        }

        private void lbdays_Click(object sender, EventArgs e)
        {

        }
    }
}
