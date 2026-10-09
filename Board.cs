class Board
{
    private char[][] _board =
    {
        [' ', ' ', ' '],
        [' ', 'X', ' '],
        [' ', ' ', '0']
    };

    public void Render()
    {
        foreach(char[] row in _board)
        {
            foreach(char cell in row)
            {
                Console.Write(cell);
            }
            Console.WriteLine("");
        }
    }

}