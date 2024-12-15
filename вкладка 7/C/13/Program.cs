namespace _13;

    class TreeNode
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
            // Создаем бинарное поисковое дерево
            TreeNode root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);
            root.Left.Left = new TreeNode(3);
            root.Left.Right = new TreeNode(7);
            root.Right.Right = new TreeNode(20);

            // Находим минимальный элемент
            int minValue = FindMin(root);
            Console.WriteLine($"Минимальный элемент в бинарном поисковом дереве: {minValue}");
        }

        static int FindMin(TreeNode node)
        {
            // Если узел не существует, выбрасываем исключение
            if (node == null)
            {
                throw new InvalidOperationException("Дерево пустое.");
            }

            // Если у узла нет левого поддерева, это минимальный элемент
            if (node.Left == null)
            {
                return node.Value;
            }

            // Рекурсивно ищем минимальный элемент в левом поддереве
            return FindMin(node.Left);
        }
    }
