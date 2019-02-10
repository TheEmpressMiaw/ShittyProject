using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread splashThread = new Thread(new ThreadStart(AppStart));
            splashThread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            splashThread.Abort();
        }
        
        public void AppStart()
        {
            Application.Run(new SplashScreen());
        }
    }
}
