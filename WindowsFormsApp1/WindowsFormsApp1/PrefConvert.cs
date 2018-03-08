using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PrefConvert
    {
        public PrefConvert(string pref, int prefScore = 0)
        {          
            switch(pref)
            {
                case "SL":
                    prefScore = 2;
                    break;

                case "Like":
                    prefScore = 1;
                    break;

                case "Neutral":
                    prefScore = 0;
                    break;

                case "Dislike":
                    prefScore = -1;
                    break;

                case "SD":
                    prefScore = -2;
                    break;

                default:
                    break;
            }
        }
        
        public int PrefScore{ get; }
    }
}
