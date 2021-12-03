using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day3
{
    internal class ByteCalculator
    {

        public byte[,] Bytes { get; set; }

        public ByteCalculator(string[] lines)
        {
            PopulateBytes(lines);
        }

        protected virtual void PopulateBytes(string[] lines)
        {
            int height = lines.Length;
            if (height <= 0)
                return;
            int width = lines[0].Length;
            Bytes = new byte[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Bytes[y, x] = byte.Parse(lines[y].ElementAt(x).ToString());
                }
            }
        }

        public virtual int CalculateGammaRage()
        {
            string byteCode = "";
            for (int x = 0; x < Bytes.GetLength(1); x++)
            {
                int oneCount = 0;
                for (int y = 0; y < Bytes.GetLength(0); y++)
                {
                    if(Bytes[y, x] == 1)
                        oneCount++;
                }
                if (oneCount > Bytes.GetLength(0) / 2)
                    byteCode += "1";
                else
                    byteCode += "0";
            }

            return Convert.ToInt32(byteCode, 2);
        }

        public virtual int CalculateEpsilonRate()
        {
            string byteCode = "";
            for (int x = 0; x < Bytes.GetLength(1); x++)
            {
                int oneCount = 0;
                for (int y = 0; y < Bytes.GetLength(0); y++)
                {
                    if (Bytes[y, x] == 1)
                        oneCount++;
                }
                if (oneCount < Bytes.GetLength(0) / 2)
                    byteCode += "1";
                else
                    byteCode += "0";
            }

            return Convert.ToInt32(byteCode, 2);
        }


        public virtual int CalculateValue()
        {
            return CalculateGammaRage() * CalculateEpsilonRate();
        }


    }
}
