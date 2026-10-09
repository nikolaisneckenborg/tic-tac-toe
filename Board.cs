using System.Diagnostics.Metrics;

class Board
{
    private char[][] _board =
    {
        [' ', ' ', ' '],
        [' ', ' ', ' '],
        [' ', ' ', ' ']
    };

    private char _currentMarker = 'X';

    public char CurrentMarker{
        get{ return _currentMarker; }
    }
    public char[][] Matrix
    {
        get{ return _board; }
    }

    public void Render()
    {
        Console.WriteLine("-------------");
        int counter = 1;
        foreach(char[] row in _board)
        {
            foreach(char cell in row)
            {
                Console.Write($"| {(cell == ' ' ? counter : cell.ToString())} ");
                counter++;
            }
            Console.WriteLine("|");
            Console.WriteLine("-------------");
        }
    }

    public bool PlaceMarker(int row, int col)
    {
        if(_board[row][col] != ' ')
        { 
            return false; 
        }
        _board[row][col] = _currentMarker;

        _currentMarker = _currentMarker == 'X' ? 'O': 'X';
        return true;
    }

    public bool PlaceMarker(int position)
    {
        if(position < 1 || position > 9){ return false;}
        position -= 1;
        int row = position / 3;
        int col = position % 3;
        return PlaceMarker(row, col);
    }

}