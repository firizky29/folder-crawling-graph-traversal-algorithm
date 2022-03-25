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
using System.IO;

namespace Folder_Crawling
{
    public partial class Form1 : Form
    {
        public delegate void update(Microsoft.Msagl.Drawing.Graph graph);
        private bool mutexLock;
        ThreadStart threadStart;
        Thread thread;
        Graph g;
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
            string nama_file = textBox2.Text;
            bool all = checkBox1.Checked;
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            string path_root = textBox1.Text;
            if (!Directory.Exists(path_root))
            {
                Console.WriteLine("Path does not exist.");
            }
            else
            {
                string root;
                Queue<string> q = new Queue<string>() ;
                q.Enqueue(path_root);
                while (q.Count() != 0)
                {
                    root = q.Dequeue();
                    //check if root is a file or folder
                    FileAttributes att = File.GetAttributes(root);
                    if ((att & FileAttributes.Directory) != FileAttributes.Directory) continue; // berarti root = file
                    string[] entries = Directory.GetFileSystemEntries(root, "*", SearchOption.TopDirectoryOnly);
                    List<string> l = new List<string>();
                    foreach(string e in entries)
                    {
                        Console.WriteLine("root : " + root + "e : " + e);
                        l.Add(e);
                        q.Enqueue(e);
                    }
                    list.Add(root, l);
                }
                
            }
            /*
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
            */
            this.g = new Graph(this, path_root, list);
            if (radioButton1.Checked)
            {
                this.g.DFS(nama_file, all);
            }
            else
            {
                this.g.BFS(nama_file, all);
            }
            //string path = "";
            //foreach (var q in g.getPath())
            //{
            //   path += q;
            // path += " ";
            //}
            //this.label1.Text = path;


            mutexLock = false;
        }
        public void updateGraph(Microsoft.Msagl.Drawing.Graph gp)
        {
            this.gViewer1.Graph=gp;
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

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.g.setDelay(this.trackBar1.Value);
        }
    }
}
