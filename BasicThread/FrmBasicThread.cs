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

namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private Thread ThreadA, ThreadB;

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Start of Thread-");
            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);
            
            ThreadA = new Thread(threadStart);
            ThreadB = new Thread(threadStart);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("End of Thread");

            lblLabel.Text = "-End of Thread-";
        }
    }
}
