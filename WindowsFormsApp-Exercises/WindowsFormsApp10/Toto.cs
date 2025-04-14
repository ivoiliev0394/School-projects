using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Toto
    {
        private int[] array;
        int cnt, from;
        private int sh = 10000;
        public Toto(int cnt, int from)
        {
            this.cnt = cnt;
            this.from = from;
        }
        private void FillNumber()
        {
            array = new int[from];
            for (int i = 0; i < from; i++)
            {
                array[i] = i + 1;
            }
        }
        private void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < sh; i++)
            {
                int x = r.Next(0, from);
                int y = r.Next(0, from);
                int temp = array[x];
                array[x] = array[y];
                array[y] = temp;
            }
        }
        public void Draw()
        {
            FillNumber();
            Shuffle();
            for(int i = 0; i <cnt; i++)
            {
                array[i].ToString();
                
            }
        }
        public override string ToString()
        {
            FillNumber();
            Shuffle();
            string s = "";
            for (int i = 0; i < cnt; i++)
            {
                s = s + array[i] + " ";
            }
            return s;
        }
    }
}
