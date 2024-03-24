using System;

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
            this.title = judul;
            this.id = random.Next(10000,99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int jumlah) {
            this.playCount=playCount+jumlah;
        }
        public void PrintVideoDetails() {
            Console.WriteLine("ID :" + id);
            Console.WriteLine("title :" + title);
            Console.WriteLine("Play Count :"+playCount);
        }
    }
}