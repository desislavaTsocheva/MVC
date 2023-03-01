using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRepair.Model
{
    public class Repair
    {
        public Repair(int playGroundsLenght,int tileWidth,int tileLenght, int benchWidth,int benchLength)
        {
            this.BenchWidth = benchWidth;
            this.TileWidth = tileWidth;
            this.BenchLenght = tileWidth;
            this.PlayGroundsLenght = playGroundsLenght;
            this.TileLenght=tileLenght;
        }
        private int playGroundsLenght;
        private int tileWidth;
        private int tileLenght;
        private int benchWidth;
        private int benchLength;
        public int PlayGroundsLenght { get { return playGroundsLenght; } set { playGroundsLenght = value; } }
        public int TileWidth { get { return tileWidth; } set { tileWidth = value; } }
        public int TileLenght { get { return tileLenght; } set { benchLength = value; } } 
        public int BenchWidth { get { return benchWidth; } set { benchWidth = value; } }    
        public int BenchLenght { get { return benchLength; } set { benchLength = value; } }

        public void OutPutInfo()
        {
            int area = playGroundsLenght * playGroundsLenght;
            int benchArea =benchLength* benchWidth;
            int areaCover = area-benchArea;
            int tileArea= tileLenght* tileWidth;
            int tileNeed = areaCover / tileArea;
            double timeNeed = tileNeed * 0.2;
            Console.Write($"tile count: {tileNeed}");
            Console.Write($"time need:{timeNeed}");

        }

    }
}
