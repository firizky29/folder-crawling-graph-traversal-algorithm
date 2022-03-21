using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Folder_Crawling.src.Graph
{
    internal class Graph
    {
        private Microsoft.Msagl.Drawing.Graph tree;
        private Dictionary<string, string> pathId;
        private Dictionary<string, string> pathName;
        private List<string> path;
        private Form1 form;

        public Graph(Form1 form, string root, Dictionary<string, List<string>> adjList)
        {
            this.tree = new Microsoft.Msagl.Drawing.Graph("graph");
            this.pathId = new Dictionary<string, string>();
            this.pathName = new Dictionary<string, string>();
            this.path = new List<string>();
            this.form = form;

            char[] delim = {'\\'};
            tree.AddNode("0");
            tree.FindNode("0").LabelText = root.Split(delim).ToList().Last();
            pathId[root] = "0";
            pathName["0"] = root.Split(delim).ToList().Last(); ;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(root);
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            visited[root] = true;
            int j = 1;
            while(queue.Count > 0)
            {
                string path = queue.Dequeue();
                string par = pathId[path];
                if (!adjList.ContainsKey(path)) continue;
                foreach(string adj in adjList[path])
                {
                    if (visited.ContainsKey(adj)) continue;
                    visited[adj] = true;
                    string q = adj.Split(delim).ToList().Last();
                    tree.AddNode(j.ToString());
                    tree.FindNode(j.ToString()).LabelText = q;
                    tree.FindNode(j.ToString()).IsVisible = false;
                    pathId[adj] = j.ToString();
                    pathName[j.ToString()] = q;
                    tree.AddEdge(par, j.ToString()).IsVisible = false;
                    queue.Enqueue(adj);
                    j++;
                }
            }
        }

        public Microsoft.Msagl.Drawing.Graph getTree()
        {
            return this.tree;
        }

        public List<string> getPath()
        {
            return this.path;
        }

        public void DFS(string to, bool all)
        {
            Microsoft.Msagl.Drawing.Graph graph = tree;
            string curPath = pathName["0"];
            string root = "0";
            if (!processDFS(root, to, graph, curPath, all))
            {
                finish(graph, root, false);
                this.path.Clear();
                this.path.Add("Tidak ditemukan");
            }
            else
            {
                finish(graph, root, true);
            }
        }
        private bool processDFS(string p, string to, Microsoft.Msagl.Drawing.Graph g, string path, bool all)
        {
            string tmp = path;
            bool ret = false;
            if (pathName[p] == to)
            { 
                this.path.Add(path);
                return true;
            }
            foreach(var e in g.FindNode(p).OutEdges)
            {
                string q = e.Target;
                path += "\\";
                path += pathName[q];
                advance(g, e);
                if(processDFS(q, to, g, path, all))
                {
                    ret = true;
                    backtrack(g, e, true);
                    if (!all)
                    {
                        return true;
                    }
                }
                else
                {
                    backtrack(g, e, false);
                    path = tmp;
                }
            }
            return ret;
        }

        private void advance(Microsoft.Msagl.Drawing.Graph g, Microsoft.Msagl.Drawing.Edge e)
        {
            Microsoft.Msagl.Drawing.Node n = g.FindNode(e.Target);
            if (!n.IsVisible)
            {
                e.IsVisible = true;
                n.IsVisible = true;
            }
            n.Attr.FillColor = Microsoft.Msagl.Drawing.Color.DarkGreen;
            g.FindNode(e.Source).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightGreen;
            this.form.processGraph(g);
            Thread.Sleep(500);
        }

        private void backtrack(Microsoft.Msagl.Drawing.Graph g, Microsoft.Msagl.Drawing.Edge e, bool solution)
        {
            Microsoft.Msagl.Drawing.Node n = g.FindNode(e.Target);

            if (solution)
            {
                n.Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightGreen;
            }
            else
            {
                n.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            }
            g.FindNode(e.Source).Attr.FillColor = Microsoft.Msagl.Drawing.Color.DarkGreen;
            this.form.processGraph(g);
            Thread.Sleep(500);
        }


        private void finish(Microsoft.Msagl.Drawing.Graph g, string finalNode, bool solution)
        {
            if (solution)
            {
                g.FindNode(finalNode).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightGreen;
            }
            else
            {
                g.FindNode(finalNode).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            }
            this.form.processGraph(g);
            Thread.Sleep(500);
        }
    }
}
