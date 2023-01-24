/*
Given a binary tree, check whether it is a mirror of itself.
*/

public class TreeNode{
    public int value;
    public TreeNode left, right;
    public TreeNode(int value)
    {
        this.value = value;
        this.left = right = null;
    }
}


public class SymmetricTree {

    private TreeNode _mainNode;

    public SymmetricTree(TreeNode mainNode)
    {
        _mainNode = mainNode;
    }
    
    public bool isMirror(TreeNode node1 , TreeNode node2)
    {
            // check if bought are null
            if(node1 == null && node2 == null)
                return true;

            // check if the right and left are equals
            if(node1 != null && node1 !=null 
            && node1.value == node2.value)        
                return ( isMirror(node1.left , node2.right) &&
                         isMirror(node1.right, node2.left) );

            return false;
    }

    public bool IsSymmetricTree(){
        return isMirror(_mainNode,_mainNode);
    }

}