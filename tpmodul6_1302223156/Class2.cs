using System;
using System.ComponentModel.DataAnnotations;
namespace tpmodul6_1302223156
{
    public class SayaTubeVideo
    {
        int id;
        private Random random = new Random();
        private string title;
        private int playCount;
        
        public SayaTubeVideo(String judul)
        {
            if (judul != null && judul.Length <= 100)
            {
                this.id = random.Next(10000, 99999);
                this.title = judul;
                this.playCount = 0;
            }
        }

        public void increasePlayCount(int jumlah)
        {
            if (jumlah <= 10000000)
            {
                try
                {
                    checked
                    {
                        this.playCount = playCount + jumlah;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow terdeteksi. Eksekusi dihentikan.");
                }
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID :" + id);
            Console.WriteLine("title :" + title);
            Console.WriteLine("Play Count :" + playCount);
        }
    }
}
    
