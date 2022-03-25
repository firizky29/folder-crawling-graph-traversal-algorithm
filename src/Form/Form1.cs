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
using System.Diagnostics;

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
            g = new Graph(this);
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
            Stopwatch stopWatch = new Stopwatch();

            try
            {
                string nama_file = textBox2.Text;
                bool all = checkBox1.Checked;
                Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
                string path_root = textBox1.Text;

                if (!Directory.Exists(path_root))
                {
                    Console.WriteLine("Path does not exist.");
                    MessageBox.Show("Path does not exist!", "Path Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string root;
                    Queue<string> q = new Queue<string>();
                    q.Enqueue(path_root);
                    while (q.Count() != 0)
                    {
                        root = q.Dequeue();
                        //check if root is a file or folder
                        FileAttributes att = File.GetAttributes(root);
                        if ((att & FileAttributes.Directory) != FileAttributes.Directory) continue; // berarti root = file
                        string[] entries = Directory.GetFileSystemEntries(root, "*", SearchOption.TopDirectoryOnly);
                        List<string> l = new List<string>();
                        foreach (string e in entries)
                        {
                            Console.WriteLine("root : " + root + "e : " + e);
                            l.Add(e);
                            q.Enqueue(e);
                        }
                        list.Add(root, l);
                    }
                }
                
                g = new Graph(this, path_root, list);
                stopWatch.Start();

                if (radioButton1.Checked)
                {
                    g.DFS(nama_file, all);
                }
                else
                {
                    g.BFS(nama_file, all);
                }
            } catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Permission Error! Unable to access path!", "Path Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            if (this.elapsedTimeLabel.InvokeRequired)
            {
                this.elapsedTimeLabel.Invoke(new MethodInvoker(delegate { this.elapsedTimeLabel.Text = ts.TotalSeconds.ToString() + " s"; }));
            }
            else
            {
                this.elapsedTimeLabel.Text = ts.TotalSeconds.ToString() + " s";
            }

            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.Invoke(new MethodInvoker(delegate {
                    richTextBox1.Text = "Solution Path: \n";
                    foreach (string path in g.getPath())
                    {
                        richTextBox1.Text += "- file:\\\\" + path + "\n\n";
                    
                    }  
                    }));
                 
            }
            else
            {
                richTextBox1.Text = "";
                foreach (string path in g.getPath())
                {
                    richTextBox1.Text += "- file:\\\\" + path + "\n";

                }
            }
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
            g.setDelay(this.trackBar1.Value);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
            //var filePath = new Uri(e.LinkText).AbsolutePath;
        }
    }
}
