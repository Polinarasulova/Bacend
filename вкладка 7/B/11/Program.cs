namespace _11;

class Program
{
    static void Main(string[] args)
    {
        int[,] maze = {
            { 0, 1, 0, 0, 0 },
            { 0, 1, 0, 1, 0 },
            { 0, 0, 0, 1, 0 },
            { 1, 1, 0, 0, 0 },
            { 0, 0, 1, 1, 0 }
        };

        // Начальная и конечная точки
        (int startX, int startY) = (0, 0);
        (int endX, int endY) = (4, 4);

        // Поиск пути
        if (FindPath(maze, startX, startY, endX, endY))
        {
            Console.WriteLine("Путь найден!");
        }
        else
        {
            Console.WriteLine("Путь не найден.");
        }
    }

    static bool FindPath(int[,] maze, int x, int y, int endX, int endY)
    {
        if (x < 0 || x >= maze.GetLength(0) || y < 0 || y >= maze.GetLength(1) || maze[x, y] == 1)
            return false; 

        
        if (x == endX && y == endY)
            return true;

       
        maze[x, y] = 1;

       
        if (FindPath(maze, x + 1, y, endX, endY) || 
            FindPath(maze, x - 1, y, endX, endY) || 
            FindPath(maze, x, y + 1, endX, endY) || 
            FindPath(maze, x, y - 1, endX, endY))   
        {
            return true; 
             maze[x, y] = 0; 
             return false;
    }
}