// C# program for different
// tree traversals
using System;
 
/* Class containing left and
right child of current
node and key value*/
class Node {
    public string name;
    public List<Node> nodes;
 
    public Node(string name)
    {
        this.name = name;
        nodes = new List<Node>();
    }

    public void Add(string nodeName)
    {
        //if(nodes == null)
            
        
        nodes.Add(new Node(nodeName));
    }
}
 
class Tree {
    // Root of Binary Tree
    Node root;
 
    Tree() { root = null; }
 
    /* Given a binary tree, print
       its nodes according to the
       "bottom-up" postorder traversal. */
    void printPostorder(Node node)
    {
        if (node == null)
            return;
 
        foreach (var n in node.nodes)
            printPostorder(n);
 
        // now deal with the node
        Console.Write(node.name + " ");
    }
 
    /* Given a binary tree, print
       its nodes in inorder*/
    void printInorder(Node node)//todo fix
    {
        if (node == null)
            return;

        var nodesCount = node.nodes.Count;
        
        for (int i = 0; i < nodesCount-1; i++)
        {
           // if (i == node.nodes.Count - 1) break;
            printInorder(node.nodes[i]);
        }
        Console.Write(node.name + " ");
        
        if(node.nodes.Count > 1)//last one
        printInorder(node.nodes[nodesCount-1]);//إن شاء الله يسبر
    }
 
    /* Given a binary tree, print
       its nodes in preorder*/
    void printPreorder(Node node)
    {
        if (node == null)
            return;
        
        /* first print data of node */
        Console.Write(node.name + " ");


        foreach (var n in node.nodes)
            printPreorder(n);
        
        /* then recur on left subtree */
        //printPreorder(node.left);
 
        /* now recur on right subtree */
        //printPreorder(node.right);
    }
 
    // Wrappers over above recursive functions
    void printPostorder() { printPostorder(root); }
    void printInorder() { printInorder(root); }
    void printPreorder() { printPreorder(root); }
 
    // Driver Code
    static public void Main(String[] args)
    {
        Tree tree = new Tree();
        
        tree.root = new Node("1");
        tree.root.Add("2");
        tree.root.Add("3");
        tree.root.Add("4");
        
        //0 is 2
        tree.root.nodes[0].Add("5");
        tree.root.nodes[0].Add("6");
        tree.root.nodes[0].Add("7");
        
        //1 is 3
        tree.root.nodes[1].Add("8");
        tree.root.nodes[1].Add("9");
        tree.root.nodes[1].Add("10");
        
        //2 is 4 
        tree.root.nodes[2].Add("11");
        tree.root.nodes[2].Add("12");
        tree.root.nodes[2].Add("13");
        
        //0.0 is 5
        tree.root.nodes[0].nodes[0].Add("14");
        tree.root.nodes[0].nodes[0].Add("15");
        tree.root.nodes[0].nodes[0].Add("16");
        
        //0.1 is 6
        tree.root.nodes[0].nodes[1].Add("17");
        tree.root.nodes[0].nodes[1].Add("18");
        tree.root.nodes[0].nodes[1].Add("19");
        
        //0.2 is 7
        tree.root.nodes[0].nodes[2].Add("20");
        tree.root.nodes[0].nodes[2].Add("21");

        Console.WriteLine("Preorder traversal "
                          + "of binary tree is ");
        tree.printPreorder();
 
        Console.WriteLine("\nInorder traversal "
                          + "of binary tree is ");
        tree.printInorder();
 
        Console.WriteLine("\nPostorder traversal "
                          + "of binary tree is ");
        tree.printPostorder();
    }


    void CreateTree()
    {
        Tree tree = new Tree();
        
        Console.WriteLine("insert the root virtex's name, then Enter");

        string node1;
        do
        {
            node1 = Console.ReadLine();
        } while (node1 == "");
        
        PrintTree();
        tree.root = new Node(node1);

        tree.root.Add("2");
        tree.root.Add("3");
        
        tree.root.nodes[0].Add("4");
        tree.root.nodes[0].Add("5");
    }

    void PrintTree()
    {
        //don't have enough time
        //  1212 -> 123 -> 1234
        //              -> 4323
        //       -> 321 -> 3423
        //              -> 3243
        
        
        //      4312
        //    |     |
        //   432   342
        //   -
    }
}



 
// This code is contributed by Arnab Kundu
// Recoded be me :) for n>2 children tree // this code kinda sucks, I didn't understand 
//the rules 100%