using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Games
{
    class tictactoe
    {
        int length = 3;
        public Piece[,] getBoard()
        {
            Piece[,] gameBoard = {{ Piece.Cross, Piece.Circle, Piece.Cross}, { Piece.Circle, Piece.Cross, Piece.Circle}, { Piece.Circle, Piece.Circle, Piece.Circle} };
            return gameBoard;
        }

        public enum Piece
        {
            Empty,
            Cross,
            Circle
        }

        public enum Check
        {
            Row,
            Column,
            Diagonal,
            ReverseDiagonal
        }

        public void checkGameWinner(Piece[,] board)
        {
            Piece winner = Piece.Empty;

            for (int i = 0; i < length; i++)
            {
                // Check if the winner is in any row.
                winner = getWinner(board, i, Check.Row);
                if (winner != Piece.Empty)
                {
                    Console.WriteLine("Winner is in row and winner is : " + winner.ToString());
                }

                // Check if the winner is in any column.
                winner = getWinner(board, i, Check.Column);
                if (winner != Piece.Empty)
                {
                    Console.WriteLine("Winner is in column and winner is : " + winner.ToString());
                }
            }
            
            // Check if the winner is diagonal.
            winner = getWinner(board, -1, Check.Diagonal);
            if (winner != Piece.Empty)
            {
                Console.WriteLine("Winner is diagonal and winner is : " + winner.ToString());
            }

            // Check if the winner is reverse diagonal.
            winner = getWinner(board, -1, Check.ReverseDiagonal);
            if (winner != Piece.Empty)
            {
                Console.WriteLine("Winner is reverse diagonal and winner is : " + winner.ToString());
            }
        }

        private Piece getCurrentColor(Piece[,] board, int index, int var, Check check)
        {
            if (check == Check.Row)
                return board[index,var];
            else if (check == Check.Column)
                return board[var,index];
            else if (check == Check.Diagonal)
                return board[var,var];
            else if (check == Check.ReverseDiagonal)
                return board[length - 1 - var,var];

            return Piece.Empty;
        }

        private Piece getWinner(Piece[,] board, int index, Check check)
        {
            Piece currColor = getCurrentColor(board, index, 0, check);

            for (int i = 1; i < length; i++)
            {
                if (currColor != getCurrentColor(board, index, i, check))
                {
                    return Piece.Empty;
                }
            }

            return currColor;
        }
    }
}
