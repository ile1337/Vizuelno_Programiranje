using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoriska_2_VP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Songs s = new Songs("God Syria and Bashar", 5.0, 241, @"C:\Users\jakim\Desktop\GodSyriaandBashar.mp3");
                Songs s2 = new Songs("I want to break free", 3.5, 280, "exampleURL_2");
                Songs s3 = new Songs("The show must go on", 4.6, 150, "exampleURL_3");

                Album album = new Album();
                album.Name = "News Of The World";
                album.Year = 1977;
                album.addSong(s);
                album.addSong(s2);
                album.addSong(s3);
             

                Console.WriteLine(album);

                s.playSong();

                Console.ReadKey();
            }
            catch(SongNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
