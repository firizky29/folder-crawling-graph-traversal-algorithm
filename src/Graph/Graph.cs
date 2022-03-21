using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Crawling.src.Graph
{
    internal class Graph
    {
        private Microsoft.Msagl.Drawing.Graph tree;
        private Dictionary<string, string> pathId;
        private Dictionary<string, string> pathName;
        private List<string> path;

        public Graph(string root, Dictionary<string, List<string>> adjList)
        {
            tree = new Microsoft.Msagl.Drawing.Graph("graph");
            pathId = new Dictionary<string, string>();
            pathName = new Dictionary<string, string>();
            path = new List<string>();
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
                    //tree.FindNode(j.ToString()).IsVisible = false;
                    pathId[adj] = j.ToString();
                    pathName[j.ToString()] = q;
                    tree.AddEdge(par, j.ToString());
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

            if(!processDFS("0", to, graph, curPath, all))
            {
                this.path.Clear();
                this.path.Add("Tidak ditemukan");
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
                if (!e.Source.Equals(p))
                {
                    q = e.Source;
                }
                path += "\\";
                path += pathName[q];
                if(processDFS(q, to, g, path, all))
                {
                    ret = true;
                    if (!all)
                    {
                        return true;
                    }
                }
                else
                {
                    path = tmp;
                }
            }
            return ret;
        }
    }
}
