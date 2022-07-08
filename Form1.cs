using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SpamBot
{
 
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                
                
                if (checkBox1.Checked)
                {
                    if (GetAsyncKeyState(Keys.Up) < 0)
                    {
                        int n = 0;
                        int x = int.Parse(textBox2.Text);
                        string f = textBox1.Text;

                        while (n < x)
                        {
      
                             try
                             {
                                SendKeys.SendWait(f + "{ENTER}");
                                Thread.Sleep(1);
                                n++;
                             }
                             catch
                             {
        
                             }
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
