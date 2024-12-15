namespace _15;

class Program
{
    static void Main(string[] args)
    {
     {
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class Program
{
    static void Main()
    {
        // Создаем бинарное дерево
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);
        root.Right.Left = new TreeNode(6);
        root.Right.Right = new TreeNode(7);

        Console.WriteLine("Обход в глубину (pre-order):");
        PreOrderTraversal(root);

        Console.WriteLine("\nОбход в глубину (in-order):");
        InOrderTraversal(root);

        Console.WriteLine("\nОбход в глубину (post-order):");
        PostOrderTraversal(root);
    }

    static void PreOrderTraversal(TreeNode node)
    {
        if (node == null) return;

        Console.Write(node.Value + " "); 
        PreOrderTraversal(node.Left);     
        PreOrderTraversal(node.Right);    
    }

        static void InOrderTraversal(TreeNode node)
    {
        if (node == null) return;

        InOrderTraversal(node.Left);      
        Console.Write(node.Value + " ");  
        InOrderTraversal(node.Right);     
    }

    
    static void PostOrderTraversal(TreeNode node)
    {
        if (node == null) return;

        PostOrderTraversal(node.Left);    
        PostOrderTraversal(node.Right);   
        Console.Write(node.Value + " ");  
    }
