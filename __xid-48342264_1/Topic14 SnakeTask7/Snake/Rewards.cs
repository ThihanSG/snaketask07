using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Rewards
    {
        List<Position> applelist;
        Board mainBoard;

        public Rewards(int size, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            applelist = new List<Position>();
            for (int i=0;i< size;i++)
            {
                int rowNo, colNo;

                //Generate an apple at random position but not duplicated
                do
                {
                    //Generate a random number between 1 and MaxRowNo
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo()+1);

                    //Generate a random number between 1 and MaxColNo
                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo()+1);

                } while (isDuplicate(rowNo, colNo) == true);

                applelist.Add(new Position(rowNo, colNo));

            }
        }

        private Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< applelist.Count;i++)
            {
                if (applelist[i].getRowNo() == row && applelist[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        
        public void draw()
        {
            for (int i = 0; i < applelist.Count; i++)
            {
                mainBoard.draw(applelist[i], Properties.Resources.apple);
            }     
        }
    }
}
