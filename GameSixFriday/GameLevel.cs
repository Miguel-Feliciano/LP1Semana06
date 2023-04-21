using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private Difficulty diff;
        private int roomNum;
        private Foe[] foes;
        public GameLevel(int roomNum, Difficulty diff)
        {
            this.diff = diff;
            this.roomNum = roomNum;
            this.foes = new Foe[roomNum];
        }

        public void SetFoeInRoom(int roomIndex, Foe foe)
        {
            if (roomIndex >= 0 && roomIndex < roomNum)
            {
                foes[roomIndex] = foe;
            }
        }
    }
}