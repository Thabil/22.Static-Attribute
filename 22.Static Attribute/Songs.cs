using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Songs
    {
        public string title; 
        public string artist;
        public int duration;
        
        public static int songCount = 0; //declaration of the static attribute
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;//increment eact time a song is added
        }
    }
}
