// Tic-Tac-Toe game
// Brycen Taylor CSE210

class TicTacToe
{
    static void Main(string[] args)
    {
// datatype class 'Board'
// new instance name 'board
// create new one of those classes 'Board()'
        Board board = new Board();
        string currentPlayer = "x";

        while (!IsGameOver(board))
        {
            DisplayBoard(board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        board.print();
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        //return new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        //new List<string> board = new List<string>();
        //for (int i = 1; i< = 9; i += 1)
        //{
        //  board.Add(i.ToString());
        //}
        //return board;
    }

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {
        return IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board);
    }

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {
        bool isWinner = false;
        if ((board[0] == player && board[1] == player && board[2] == player)
            || (board[3] == player && board[4] == player && board[5] == player)
            || (board[6] == player && board[7] == player && board[8] == player)
            || (board[0] == player && board[3] == player && board[6] == player)
            || (board[1] == player && board[4] == player && board[7] == player)
            || (board[2] == player && board[5] == player && board[8] == player) 
            || (board[0] == player && board[4] == player && board[8] == player)
            || (board[2] == player && board[4] == player && board[6] == player)
            )
        {
            isWinner = true;
        }
        return isWinner;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {
        foreach(string value in board)
        {
            if(char.IsDigit(value[0]))
            {
                return false;
            }
        }
        return true;
        }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        if (currentPlayer == "o")
            {
                return "x";
            }
                return "o";}

    /**
    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    **/
    static int GetMoveChoice(string currentPlayer, List<string> board)
    {
        Console.WriteLine("Where would you like to go?");
        string? userChoice = Console.ReadLine();
        {
            bool properDigit = false;
            if ((userChoice == "1")
            || (userChoice == "2")
            || (userChoice == "3")
            || (userChoice == "4")
            || (userChoice == "5")
            || (userChoice == "6")
            || (userChoice == "7")
            || (userChoice == "8")
            || (userChoice == "9")){
                properDigit = true;
            }
            if (properDigit == true){
                foreach(string value in board)
                {
                    if(userChoice == (value[0]))
                    {
                        choice = Int16.Parse(userChoice);
                        return choice;
                    }
                }
                return true;
                }
        }
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
     
    }
}
