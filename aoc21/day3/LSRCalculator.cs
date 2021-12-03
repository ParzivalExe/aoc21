using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc21.day3
{
    internal class LSRCalculator
    {

        public List<byte[]> Bytes { get; set; }

        public LSRCalculator(string[] lines)
        {
            PopulateBytes(lines);
        }

        protected virtual void PopulateBytes(string[] lines)
        {
            int height = lines.Length;
            if (height <= 0)
                return;
            int width = lines[0].Length;
            Bytes = new List<byte[]>();
            for (int y = 0; y < height; y++)
            {
                Bytes.Add(new byte[width]);
                for (int x = 0; x < width; x++)
                {
                    Bytes[y][x] = byte.Parse(lines[y].ElementAt(x).ToString());
                }
            }
        }

        public virtual int CalculateOxygenGenerator()
        {
            List<byte[]> bytes = new List<byte[]>(Bytes);

            for (int x = 0; x < bytes[0].Length; x++)
            {
                int oneCount = 0;
                for (int y = 0; y < bytes.Count; y++)
                {
                    if (bytes[y][x] == 1)
                        oneCount++;
                }
                if (oneCount >= bytes.Count / 2f)
                    bytes.RemoveAll(value => value[x] == 0);
                else
                    bytes.RemoveAll(value => value[x] == 1);
                if (bytes.Count == 1)
                {
                    string byteCode = "";
                    foreach (byte b in bytes.First())
                        byteCode += b.ToString();
                    return Convert.ToInt32(byteCode, 2);
                }
            }
            return -1;
        }

        public virtual int CalculateCO2Scrubber()
        {
            List<byte[]> bytes = new List<byte[]>(Bytes);

            for (int x = 0; x < bytes[0].Length; x++)
            {
                int oneCount = 0;
                for (int y = 0; y < bytes.Count; y++)
                {
                    if (bytes[y][x] == 1)
                        oneCount++;
                }
                if (oneCount < bytes.Count / 2f)
                    bytes.RemoveAll(value => value[x] == 0);
                else
                    bytes.RemoveAll(value => value[x] == 1);
                if (bytes.Count == 1)
                {
                    string byteCode = "";
                    foreach (byte b in bytes.First())
                        byteCode += b.ToString();
                    return Convert.ToInt32(byteCode, 2);
                }
            }
            return -1;
        }

        public virtual int CalculateValue()
        {
            return CalculateOxygenGenerator() * CalculateCO2Scrubber();
        }

    }
}
