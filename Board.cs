using System.Diagnostics.Metrics;

class Board
{
    private char[][] _board =
    {
        [' ', ' ', ' '],
        [' ', ' ', ' '],
        [' ', ' ', ' ']
    };

    public void Render()
    {
        Console.WriteLine("-------------");
        int counter = 1;
        foreach(char[] row in _board)
        {
            foreach(char cell in row)
            {
                Console.Write($"| {(cell == ' ' ? counter++ : cell.ToString())} ");
            }
            Console.WriteLine("|");
            Console.WriteLine("-------------");
        }
    }

}