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

        public Difficulty GetDifficulty()
        {
            return diff;
        }
        public int GetNumRooms()
        {
            return roomNum;
        }
        public int GetNumFoes()
        {
            int count = 0;
            foreach (Foe foe in foes)
            {
                if (foe != null)
                {
                    count++;
                }
            }
            return count;
        }
        public void PrintFoes()
        {
            for (int i = 0; i < foes.Length; i++)
            {
                if (foes[i] != null)
                {
                    Console.WriteLine($"Room {i}: {foes[i].GetName()}");
                }
            }
        }
    }
}