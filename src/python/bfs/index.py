from collections import defaultdict
class Graph: # constructor init
    def __init__(self):
        self.graph = defaultdict(list)

    # relation between nodes
    def setEdge(self,u,v):
        self.graph[u].append(v)
    
    def bfs(self,startNode):
        #represents the nodes visited
        visited = set()

        queue = []
        queue.append(startNode)

        visited.add(startNode)

        while(queue):
            u = queue.pop(0)
            print(u, end=" ")

            for vetor in self.graph[u]:
                if vetor not in visited:
                    queue.append(vetor)
                    visited.add(vetor)

g = Graph()
g.setEdge(2,1)
g.setEdge(2,5)
g.setEdge(5,6)
g.setEdge(5,8)
g.setEdge(6,9)

g.bfs(2)
