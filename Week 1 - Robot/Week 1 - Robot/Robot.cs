using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week_1___Robot
{
    public class Robot
    {
        private int richting;
        private int plaats;

        public Robot(int plaats, int richting)
        {
            this.plaats = plaats;
            this.richting = richting;
        }

        public void zetEenStapLinks()
        {
            plaats--;
            
        }

        public void zetEenStapRechts()
        {
            plaats++;
        }        

        public void GaNaar(int bestemming)
        {
        }

        public int HaalRichtingOP()
        {
            return richting;
        }

        public int HaalPlaatsOP()
        {
            return plaats;
        }
    }
}