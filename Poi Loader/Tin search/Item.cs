using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poiLoader
{
    class Item
    {


        public bool hasname(string name)
        {
            if (this.name.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool hasreforge(string name)
        {

            if (masterstring.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string masterstring {  get; set; }
        //all items WILL have these
        public int classid { get; set; }
        public string pocket { get; set; }
        public string name { get; set; }
        public int xpos { get; set; }
        public int ypos { get; set; }
        public string[] colour { get; set; }

        //equips will have these
        public int currentdura { get; set; }
        public int maxdura { get; set; }
        public bool ishammered { get; set; }
        public int proficiency { get; set; }
        public int upgrades { get; set; }

        //amour will have these
        public int defense { get; set; }
        public int protection { get; set; }

        //weapons will have these
        public int minattack { get; set; }
        public int maxattack { get; set; }
        public int balance { get; set; }
        public int critical { get; set; }
        //magic
        public int magicattack { get; set; }

        //weapons may have these
        public int range { get; set; }

        //extra flags for gear
        public int reforgelevel { get; set; }
        public string[] reforges { get; set; }
        public int tradesremaining { get; set; }

        //extra flags
        public int lifeadded { get; set; }
        public int manaadded { get; set; }
        public int staminaadded { get; set; }
        public int strengthadded { get; set; }
        public int intelligenceadded { get; set; }
        public int dexterityadded { get; set; }
        public int willadded { get; set; }
        public int luckadded { get; set; }
    }
}
