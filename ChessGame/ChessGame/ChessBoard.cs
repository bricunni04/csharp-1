﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class ChessBoard
    {
        static ChessBoard me;
        ChessSquare[,] m_b = new ChessSquare[8, 8];
        public ChessBoard(System.Windows.Forms.PictureBox[,] pictureBoxes)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    m_b[r, c] = new ChessSquare(r+1,c+1, pictureBoxes[r,c]);
                    System.Console.WriteLine(m_b[r, c]);
                }
            }
            me = this;
        }
        public static ChessBoard GetBoard()
        {
            return me;
        }
        public ChessSquare GetSquare(int r, int c)
        {
            return m_b[r, c];
        }
  
    }
}
