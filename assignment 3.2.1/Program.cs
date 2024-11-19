namespace assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 2, 3, 4 },
                               { 1, 4, 6 } };

            Console.WriteLine("2D array: ");
            for (int i = 0; i < matrix.GetLength(0); i++) // Loop through rows
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(1); j++) // Loop through columns
                {
                    Console.Write($" {matrix[i, j]} |");
                }
                Console.WriteLine(); // Move to the next row
            }

            string[,] grid = { { "Bugatti", "lamborghini", "tesla" }, 
                                {"Chiron","Aventador","Modelx" } };
            Console.WriteLine("2D array practice: ");
            for(int i = 0;i < grid.GetLength(0); i++) 
            {
                Console.Write("|"); //this messed up my code lol  
                for(int j = 0;j < grid.GetLength(1); j++)
                {
                    Console.Write($"{grid[i, j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}