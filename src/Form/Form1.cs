using Folder_Crawling.src.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Crawling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
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
            Graph g = new Graph("C:", list);
            this.gViewer1.Graph = g.getTree();
            g.DFS("H");
            this.label1.Text = g.getPath();
        }
    }
}
