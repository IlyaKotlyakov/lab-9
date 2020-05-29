using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XMLGUI.Forms;
using XMLGUI.EventsLib;
using System.Threading;

namespace XMLGUI
{
    public partial class ThreadConstr : Form
    {
        private delegate void SafeCallDelegate(string text, Color r);

        public ThreadConstr()
        {
            InitializeComponent();
        }
      
            static int sleeping = 500;
            static object locker = new object();
            static object locker1 = new object();

        

        //функция для получения рандомных слов
        public static string GetRandom()
        {
            lock (locker1)
            {
                string randoms = "abcdefghijklmnopqrstuvwxyz";
                
                string[] rand = { ".", "?", "!" };

                string randsror = "";
                Random r = new Random();
                int iterations1 = r.Next(1, 14);
                int iterations2;
                for (int i = 0; i < iterations1; i++)
                {
                    iterations2 = r.Next(1, 13);
                    for (int j = 0; j < iterations2; j++)
                    {
                        randsror += randoms[r.Next(0, 13)];
                    }
                    randsror += i==iterations1-1?"":" ";
                }
                randsror += rand[r.Next(0, 3)];
                return randsror;
            }
        }

        void main(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    Thread myThread = new Thread(Count);
                    myThread.Start(num);
                }
            }
        public void Count(object num)
        {
                        
            Random r = new Random(Thread.CurrentThread.ManagedThreadId);
            int red = r.Next(0, 255)/(int)num*(Thread.CurrentThread.ManagedThreadId% (int)num+1);
            int green = r.Next(0, 255) / (int)num * (Thread.CurrentThread.ManagedThreadId % (int)num + 1);
            int blue = r.Next(0, 255) / (int)num * (Thread.CurrentThread.ManagedThreadId % (int)num + 1);
            r = null;

            Color c = Color.FromArgb(255, red, green, blue) ;


            for (int i = 1; i < 3; i++)
                {
                    lock (locker)
                    {
                        if (chat.InvokeRequired)
                        {
                        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                            Console.WriteLine(c.ToString());

                            var d = new SafeCallDelegate(WriteTextSafe);
                            chat.Invoke(d, new object[] { (Thread.CurrentThread.ManagedThreadId-2) + ":  " + GetRandom() + Environment.NewLine+ Environment.NewLine, c });
                        }
                        else
                        {
                            //tableView.Text += Thread.CurrentThread.Name;
                            //chat.Text += Thread.CurrentThread.Name + Environment.NewLine;
                        }

                        Thread.CurrentThread.Join(sleeping);
                    }
                }
                
            
        }
        
        private void WriteTextSafe(string text, Color c)
        {              
            chat.SelectionColor = c;
            if (chat.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                chat.Invoke(d, new object[] { text });
            }
            else
            {              
                chat.SelectedText += text;
            }
        }


        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuantityThreads setFilterForm = new QuantityThreads();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnThreadChangeEvent);
            setFilterForm.Show();
            

        }
        public void OnThreadChangeEvent(object sender, FilterChangeEventArgs e)
        {

            main(Convert.ToInt32(e.Param));
        }

        private void setTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTime setTimerForm = new SetTime();
            setTimerForm.SetTimeChangeEvent += new EventHandler<SetTimerEventArgs>(this.SetTimeEvent);
            setTimerForm.Show();
        }
        public void SetTimeEvent(object sender, SetTimerEventArgs e)
        {
            sleeping = Convert.ToInt32(e.Param);
        }

        
    }
}