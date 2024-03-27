using System.Diagnostics.Contracts;
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
                int max = 100;
                Contract.Requires(username.Length < max && username != null);
                try
                {
                    checked
                    {
                        if ((username == null))
                        {
                            throw new ArgumentException("username tidak bisa kosong");
                        }
                        else if (username.Length > max)
                        {
                            throw new ArgumentException("username tidak bisa melebihi 200 karakter");
                        }
                        this.username = username;
                        Random rand = new Random();
                        int minRand = 10000;
                        int maxRand = 99999;
                        this.id = rand.Next(minRand, maxRand + 1);
                        
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }

                Contract.Ensures(this.username.Length < max && username != null);

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
                if (this.username != null)
                {
                    int max = 25000000;
                    Contract.Requires(video != null);
                    try
                    {
                        checked
                        {
                            if (video == null)
                            {
                                throw new OverflowException("Title Video tidak bisa null");
                            } 
                             uploadedVideos.Add(video);
                            
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    Contract.Ensures(video != null);
                   
                } 
               
               
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

                int max = 100;
                Contract.Requires(title.Length < max && title != null);
                try
                {
                    checked
                    {
                        if ((title == null))
                        {
                            throw new ArgumentException("Title tidak bisa kosong");
                        }
                        else if (title.Length > max)
                        {
                            throw new ArgumentException("Title tidak bisa melebihi 200 karakter");
                        }
                        this.title = title;
                        Random rand = new Random();
                        int minRand = 10000;
                        int maxRand = 99999;
                        this.id = rand.Next(minRand, maxRand + 1);
                        this.playCount = 0;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }

                Contract.Ensures(this.title.Length < max && title != null);

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
                if (this.title != null)
                {
                    int max = 25000000;
                    Contract.Requires(playCount < max);
                    try
                    {
                        checked
                        {
                            if (this.playCount + playCount > max)
                            {
                                throw new OverflowException("Jumlah PlayCount melebihi 25.000.000");
                            }
                            this.playCount += playCount;
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    Contract.Ensures(this.playCount < max);
                }
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
            try
            {
                SayaTubeUser user1 = new SayaTubeUser("Aldi");
                SayaTubeVideo vid1 = new SayaTubeVideo("Review Film 1 oleh Aldi");
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
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument Exception : " + ex.Message);
                
            }
           

            
          
        
            

        }
    }
}
