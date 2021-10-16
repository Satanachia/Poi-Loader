using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poiLoader
{
    class Character
    {
        string charname;
        string invsize;
        string server;
        int numberofitems;
        string loggedarea;
        string date;
        private List<Item> myList = new List<Item>();


        public Character()
        { 
        }
        public void additem(Item item)
        {
            myList.Add(item);
        }
        public List<Item> MyList
        {
            get { return myList; }
        }
        public bool hasitem (string name)
        {
            bool hasitem = false;
            foreach(Item item in myList)
            {
                if (item.hasname(name)) {  hasitem = true;  break; }
            }
            return hasitem;
        }

        public bool hasreforge (string name)
        {
            bool hasitem = false;
            foreach (Item item in myList)
            {
                if (item.hasreforge(name)) { hasitem = true; break; }
            }
            return hasitem;
        }
        public string Charname { get => charname; set => charname = value; }
        public string Invsize { get => invsize; set => invsize = value; }
        public string Server { get => server; set => server = value; }
        public int Numberofitems { get => numberofitems; set => numberofitems = value; }
        public string Loggedarea { get => loggedarea; set => loggedarea = value; }
        public string Date { get => date; set => date = value; }
    }
}
