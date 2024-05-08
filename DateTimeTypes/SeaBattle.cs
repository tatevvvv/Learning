using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTypes
{
    internal class SeaBattle
    {
        public static void main(String[] args)
        {
            int[][] board = new int[10][];

            // here we initialize array with all 0s
            // 0 means cell is free, 1 is cell has ship, 2 means cell is srounded by ship
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    board[i][j] = 0;
                }
            }

            // placing 4 length ship
            for (int i = 0; i < 1; ++i)
            {
                placeShips(4, board);
            }

            // placing 3 length ship

            for (int i = 0; i < 2; ++i)
            {
                placeShips(3, board);
            }

            // placing 2 length ship

            for (int i = 0; i < 3; ++i)
            {
                placeShips(2, board);
            }

            // placing 1 length ship

            for (int i = 0; i < 4; ++i)
            {
                placeShips(1, board);
            }


            // just printing the board
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    Console.Write(board[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] placeShips(int size, int[][] board)
        {
            Random rnd = new Random();

            // this variable tell wheter that specific size of ship is placed or not, if not we repeat the process as mush we need to finally place the shi[
            bool shipPlaced = false;

            while (!shipPlaced)
            {

                int x = rnd.Next(9);
                int y = rnd.Next(9);

                while (board[x][y] != 0) // means it is busy, 1 is ship, 2 is close area of ship
                {
                    x = rnd.Next(9);
                    y = rnd.Next(9);
                }

                // check for full availability horizontally left

                bool atLeastOneFound = true; // this variable tell whether there is place for ship or not
                int i = y;
                for (int k = 0; k < size; k++)
                {
                    if (i < 0 || i > 9 || board[x][i] == 1 || board[x][i] == 2)
                    {
                        atLeastOneFound = false;
                        break;
                    }
                    --i;
                }
                if (atLeastOneFound)
                {
                    i = y;
                    for (int k = 0; k < size; k++)
                    {
                        board[x][i] = 1;
                        MarkAdjacentCellBusy(x + 1, i, board);
                        MarkAdjacentCellBusy(x - 1, i, board);
                        if (i == y)
                        {
                            MarkAdjacentCellBusy(x, i + 1, board);
                        }
                        if (k == size - 1)
                        {
                            MarkAdjacentCellBusy(x, i - 1, board);
                        }
                        --i;
                    }

                    shipPlaced = true;
                }

                // check for full availability horizontally right

                if (shipPlaced)
                {
                    return board;
                }
                atLeastOneFound = true;
                i = y;
                for (int k = 0; k < size; k++)
                {
                    if (i < 0 || i > 9 || board[x][i] == 1 || board[x][i] == 2)
                    {
                        atLeastOneFound = false;
                        break;
                    }
                    ++i;
                }

                if (atLeastOneFound)
                {
                    i = y;
                    for (int k = 0; k < size; k++)
                    {
                        board[x][i] = 1;
                        MarkAdjacentCellBusy(x + 1, i, board);
                        MarkAdjacentCellBusy(x - 1, i, board);
                        if (i == y)
                        {
                            MarkAdjacentCellBusy(x, i - 1, board);
                        }
                        if (k == size - 1)
                        {
                            MarkAdjacentCellBusy(x, i + 1, board);
                        }
                        ++i;
                    }

                    shipPlaced = true;
                }

                // check for full availability vertically up
                if (shipPlaced)
                {
                    return board;
                }
                atLeastOneFound = true;
                i = x;
                for (int k = 0; k < size; k++)
                {
                    if (i < 0 || i > 9 || board[i][y] == 1 || board[i][y] == 2)
                    {
                        atLeastOneFound = false;
                        break;
                    }
                    --i;
                }

                if (atLeastOneFound)
                {
                    i = x;
                    for (int k = 0; k < size; k++)
                    {
                        board[x][i] = 1;
                        MarkAdjacentCellBusy(x, i + 1, board);
                        MarkAdjacentCellBusy(x, i - 1, board);

                        if (i == x)
                        {
                            MarkAdjacentCellBusy(x + 1, i, board);
                        }
                        if (k == size - 1)
                        {
                            MarkAdjacentCellBusy(x - 1, i, board);
                        }
                        --i;
                    }
                    shipPlaced = true;
                }

                // check for full availability vertically down
                if (shipPlaced)
                {
                    return board;
                }
                atLeastOneFound = true;
                i = x;
                for (int k = 0; k < size; k++)
                {
                    if (i < 0 || i > 9 || board[i][y] == 1 || board[i][y] == 2)
                    {
                        atLeastOneFound = false;
                        break;
                    }
                    ++i;
                }

                if (atLeastOneFound)
                {
                    i = x;
                    for (int k = 0; k < size; k++)
                    {
                        board[x][i] = 1;
                        MarkAdjacentCellBusy(x, i + 1, board);
                        MarkAdjacentCellBusy(x, i - 1, board);

                        if (i == x)
                        {
                            MarkAdjacentCellBusy(x - 1, i, board);
                        }
                        if (k == size - 1)
                        {
                            MarkAdjacentCellBusy(x + 1, i, board);
                        }
                        ++i;
                    }
                    shipPlaced = true;
                }

            }
            return board;
        }


        private static void MarkAdjacentCellBusy(int i, int j, int[][] board)
        {
            if (i < 0 || i > 9 || j < 0 || j > 9)
            {
                return;
            }
            if (board[i][j] != 1)
            {
                board[i][j] = 2;
            }
        }
    }
}
