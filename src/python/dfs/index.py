from collections import defaultdict
class Graph: 
    # constructor init
    def __init__(self):
        self.graph = defaultdict(list)

    # insert the edge , added link with V1 and V2
    def insertEdge(self, v1, v2):
        self.graph[v1].append(v2)

    def DFS(self, startNode):
        visited = set() # set to check if that element is already visited
        stack = []
        stack.append(startNode)

        while(len(stack)):
            current = stack[-1] # first element
            stack.pop() # remove the element
            # check if that element is already visited
            if(current not in visited):
                print(current, end= " ")
                visited.add(current)
            
            for vertex in self.graph[current]:
                if(vertex not in visited):
                    stack.append(vertex)


g = Graph()
g.insertEdge(2,1)
g.insertEdge(2,5)
g.insertEdge(5,6)
g.insertEdge(5,8)
g.insertEdge(6,9)
g.DFS(2)