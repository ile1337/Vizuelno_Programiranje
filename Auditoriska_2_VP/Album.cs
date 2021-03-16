using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoriska_2_VP
{
    class Album
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public List<Songs> pesni { get; set; }

        public Album()
        {
            pesni = new List<Songs>();
        }

        public Album(string Name, int Year, List<Songs> pesni)
        {
            this.Name = Name;
            this.Year = Year;
            foreach(Songs pesna in pesni)
            {
                this.pesni.Add(pesna);
            }
        }

        public void addSong(Songs s)
        {
            pesni.Add(s);
        }

        public Songs findSong(string find)
        {
            foreach(Songs s in pesni)
            {
                if (s.Name.Equals(find,StringComparison.OrdinalIgnoreCase))
                {
                    return s;
                }
            }
            throw new SongNotFoundException("The song "+ find + " was not found in the album.");
        } 

        public void removeSong(string name)
        {
            for(int i=0; i < pesni.Count; ++i)
            {
                if (pesni[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    pesni.RemoveAt(i);
                    i--;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Name of album: " + Name + "\n");
            str.Append("Year: " + Year + "\n");
            str.Append("Songs:\n");
            foreach(Songs pesna in pesni)
            {
                str.Append(pesna+"\n");
            }
            return str.ToString();
        }

    }
}
