using System.Collections.Generic;

/*
Depth-first search is an algorithm for traversing or searching 
tree or graph data structures. The algorithm starts at the root 
node (selecting some arbitrary node as the root node in the case of 
a graph) and explores as far as possible along each branch before 
backtracking. 
So the basic idea is to start from the root or any arbitrary 
node and mark the node and move to the adjacent unmarked node 
and continue this loop until there is no unmarked adjacent node. 
Then backtrack and check for other unmarked nodes and traverse them. 
Finally, print the nodes in the path.
*/

namespace AArvvaniAlgorithms.Graph
{
    // Time Complexity:  O(V+E) - V quantity of vertices and E quantity of Edges
    // Space: O(V)
    public class GraphDfs {
        LinkedList<int>[] linkedList;

        public GraphDfs(int totalVertices)
        {
            linkedList = new LinkedList<int>[totalVertices];
        }
       
        internal void dfsUtil(int vertice , bool[] visited , List<int> returnList){

            if (!visited[vertice]){
                returnList.Add(vertice);
                visited[vertice] = true;
            }

            if(linkedList[vertice] != null){
                foreach (var vertex in linkedList[vertice])
                {
                    if (!visited[vertex])
                    {
                        dfsUtil(vertex, visited, returnList);
                    }
                }
            }
        }

        public List<int> DFS(int startVertice){
            var returnList = new List<int>();
            bool[] visited = new bool[linkedList.Length + 1];
            dfsUtil(startVertice, visited , returnList);
            return returnList;
        }

        public void InsertEdge(int v1, int v2){
           if(linkedList[v1] == null){
               linkedList[v1] = new LinkedList<int>();
           }
           linkedList[v1].AddFirst(v2);
        }
    }
}