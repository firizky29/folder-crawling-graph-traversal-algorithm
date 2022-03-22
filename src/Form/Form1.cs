using Folder_Crawling.src.Graph;
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

namespace Folder_Crawling
{
    public partial class Form1 : Form
    {
        public delegate void update(Microsoft.Msagl.Drawing.Graph graph);
        private bool mutexLock;
        ThreadStart threadStart;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void processGraph(Microsoft.Msagl.Drawing.Graph g)
        {
            update upd = new update(updateGraph);
            this.gViewer1.BeginInvoke(upd, g);
        }

        private void process()
        {
            // NOTE: Janlup reset graph setiap pake

            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            List<string> list2 = new List<string>();
            list2.Add("C:\\A");
            list2.Add("C:\\B");
            list2.Add("C:\\C");
            list2.Add("C:\\D");
            list2.Add("C:\\E");
            list2.Add("C:\\F");
            list.Add("C:", list2);
            List<string> list3 = new List<string>();
            list3.Add("C:\\D\\G");
            list3.Add("C:\\D\\A");
            list.Add("C:\\D", list3);
            Graph g = new Graph(this, "C:", list);
            g.BFS("A", true);
            //string path = "";
            //foreach (var q in g.getPath())
            //{
            //   path += q;
            // path += " ";
            //}
            //this.label1.Text = path;


            mutexLock = false;
        }
        public void updateGraph(Microsoft.Msagl.Drawing.Graph g)
        {
            this.gViewer1.Graph=g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mutexLock)
            {
                mutexLock = true;
                threadStart = new ThreadStart(process);
                thread = new Thread(threadStart);
                thread.Start();
            }
        }
    }
}
