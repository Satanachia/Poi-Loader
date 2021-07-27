using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Launch_using_steam
{
    class account
    {
        public string profileName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string SteamPath { get; set; }

        public account(string profile, string user, string pass, string path)
        {
            this.profileName = profile;
            this.userName = user;
            this.password = pass;
            this.SteamPath = path;
        }
        



    }
}
