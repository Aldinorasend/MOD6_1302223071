using System.Runtime.Intrinsics.X86;

namespace MOD6
{
    internal class Program
    {
        public class SayaTubeUser
        {
            private int id;
            private List<SayaTubeVideo> uploadedVideos;
            private String username;
            public SayaTubeUser(string username)
            {
                this.username = username;
                this.uploadedVideos = new List<SayaTubeVideo>();
                Random rand = new Random();
                int min = 10000;
                int max = 99999;
                this.id = rand.Next(min, max + 1);

            }
            public int getTotalVideoPlayCount()
            {
                int total = 0;
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    total = uploadedVideos[i].getPlayCount() + total;
                }
                return total;
            }

            public void addVideo(SayaTubeVideo video)
            {
                uploadedVideos.Add(video);
            }

            public void printAllVideoPlayCount()
            { 
                Console.WriteLine("User : " + username);
                for (int i = 0; i < uploadedVideos.Count;i++)
                {
                    Console.WriteLine("Video " + (i + 1) + " judul : " + uploadedVideos[i].getTitle());

                }
                Console.WriteLine("Total Playcount Semua Videos : " + getTotalVideoPlayCount());
            }
        }
        public class SayaTubeVideo
        {
            private int id;
            private String title;
            private int playCount;

            public SayaTubeVideo(String title) {
                this.title = title;
                Random rand = new Random();
                int min = 10000;
                int max = 99999;
                this.id = rand.Next(min, max + 1);
                this.playCount = 0;
            }
            public int getPlayCount()
            {
                return playCount;
            }
            public String getTitle()
            {
                return title;
            }
            public void increasePlayCount(int playCount)
            {
                this.playCount += playCount;
            }
            public void PrintVideoDetails()
            {
                Console.WriteLine("Id : " + id);
                Console.WriteLine("Title : " + title);
                Console.WriteLine("Playcount : " + playCount);
            }
        }
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("Aldi");
            SayaTubeVideo vid1 = new SayaTubeVideo("Review Film 1 oleh Aldi" );
            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film 2 oleh Aldi");
            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film 3 oleh Aldi");
            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film 4 oleh Aldi");
            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film 5 oleh Aldi");
            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film 6 oleh Aldi");
            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film 7 oleh Aldi");
            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film 8 oleh Aldi");
            SayaTubeVideo vid9 = new SayaTubeVideo("Review Film 9 oleh Aldi");
            SayaTubeVideo vid10 = new SayaTubeVideo("Review Film 10 oleh Aldi");

            user1.addVideo(vid1);
            user1.addVideo(vid2);
            user1.addVideo(vid3);
            user1.addVideo(vid4);
            user1.addVideo(vid5);
            user1.addVideo(vid6);
            user1.addVideo(vid7);
            user1.addVideo(vid8);
            user1.addVideo(vid9);
            user1.addVideo(vid10);

            
           
            vid1.increasePlayCount(1);
            vid1.PrintVideoDetails();
            vid2.increasePlayCount(1);
            vid2.PrintVideoDetails();
            vid3.increasePlayCount(1);
            vid3.PrintVideoDetails(); 
            vid4.increasePlayCount(1);
            vid4.PrintVideoDetails();
            vid5.increasePlayCount(1);
            vid5.PrintVideoDetails();
            vid6.increasePlayCount(1);
            vid6.PrintVideoDetails();
            vid7.increasePlayCount(1);
            vid7.PrintVideoDetails();
            vid8.increasePlayCount(1);
            vid8.PrintVideoDetails();
            vid9.increasePlayCount(1);
            vid9.PrintVideoDetails();
            vid10.increasePlayCount(1);
            vid10.PrintVideoDetails();
            Console.WriteLine(" ");
            user1.printAllVideoPlayCount();
           
            

        }
    }
}
