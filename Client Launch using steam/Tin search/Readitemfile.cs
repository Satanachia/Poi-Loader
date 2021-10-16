using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poiLoader
{
    class Readitemfile
    {
        static public void readitemfile(List<Character> chara, string filename)
        {
            string date = "";
            string name = "";
            string invsize = "";
            string server = "";
            int numofitems = 0;
            string loggedarea = "";          
            string[] lines = System.IO.File.ReadAllLines(filename);
            Character x = new Character();
            for (int i = 0; i < lines.Length; i++)
            {
                //Console.WriteLine("\t" + lines[i]);
                if (i == 0)
                {
                    int indexofclose = lines[0].IndexOf(']');
                    date = lines[0].Substring(0, indexofclose + 1);
                    x.Date = date;
                }
                if (i == 1)
                {
                    //System.Console.WriteLine($"trimmed string: '{lines[1]}'");
                    System.Console.WriteLine("reading file: " + filename);
                    // remove the race since we dont care
                    int indexofopen = 0;
                    int indexofclose = 0;
                    bool eventpet = false;
                    if (lines[1].Contains("(Event)"))
                    {
                        eventpet = true;
                    }
                    if (lines[1].Contains("("))
                    {
                        indexofopen = lines[1].IndexOf('(');
                        indexofclose = lines[1].IndexOf(')');
                        lines[1] = lines[1].Substring(0, indexofopen) + lines[1].Substring(indexofclose + 1);
                    }


                    //split out char name
                    indexofclose = lines[1].IndexOf("'");
                    if (eventpet)
                    {
                        name = lines[1].Substring(0, indexofclose -1);
                    }
                    else
                    {
                        name = lines[1].Substring(0, indexofclose);
                    }
                    
                    lines[1] = lines[1].Substring(indexofclose + 1);
                    //print char name for testing
                    x.Charname = name;
                    
                    if (lines[1].Contains("Mailbox"))
                    {
                        x.Charname += "'s Mailbox";
                    }
                    if (lines[1].Contains("Bank"))
                    {
                        x.Charname += "'s Bank";
                    }

                    // get inv size

                    if (lines[1].Contains("Inventory"))
                    {
                        //check if line even has a inv size
                        //System.Console.WriteLine("lines contains inv");
                        //take only the size part of string, rest doesnt matter
                        indexofopen = lines[1].IndexOf('(');
                        indexofclose = lines[1].IndexOf(')');
                        invsize = lines[1].Substring(indexofopen + 1, indexofclose - indexofopen - 1);

                        //print inv size for testing will need to converst this to int
                        x.Invsize = invsize;

                        lines[1] = lines[1].Substring(indexofclose + 2);
                    }

                    //last server logged into, mostly useless
                    if (lines[1].Contains("Server"))
                    {
                        indexofopen = lines[1].IndexOf('[') + 8;
                        indexofclose = lines[1].IndexOf(']');
                        server = lines[1].Substring(indexofopen + 1, indexofclose - indexofopen - 1);

                        x.Server = server;
                        lines[1] = lines[1].Substring(indexofclose + 2);
                    }
                    if (lines[1].Contains("Items"))
                    {
                        indexofopen = lines[1].IndexOf('[');
                        indexofclose = lines[1].IndexOf(' ');
                        numofitems = int.Parse(lines[1].Substring(indexofopen + 1, indexofclose - indexofopen - 1));
                        x.Numberofitems = numofitems;
                        indexofclose = lines[1].IndexOf(']');
                        if (lines[1].Contains("<"))
                        {
                            lines[1] = lines[1].Substring(indexofclose + 2);
                        }


                    }
                    //at this point only the last loged in area should be a thing
                    if (lines[1].Contains("<"))
                    {
                        indexofopen = lines[1].IndexOf('<');
                        indexofclose = lines[1].IndexOf('>');
                        loggedarea = lines[1].Substring(indexofopen + 1, indexofclose - indexofopen - 1);
                        x.Loggedarea = loggedarea;
                    }


                    //string[] words = lines[1].Split(delimiterChars);
                    //System.Console.WriteLine($"{words.Length} words in text:");
                    //foreach (var word in words)
                    //{
                    //    System.Console.WriteLine($"<{word}>");
                    //}
                }
                if ( i != 0 && i != 1)
                {
                    //create item for this line
                    Item item = new Item();
                    //get pocket id
                    
                    if(lines[i].Contains("ClassID"))
                    {

                        string pocket = lines[i].Substring(0, 8);
                        item.pocket = pocket;
                        //testcode
                        //Console.WriteLine(item.pocket);
                        lines[i] = lines[i].Substring(9);


                        //create our indexs we need for later
                        int indexofopen = lines[i].IndexOf('[');
                        int indexofclose = lines[i].IndexOf(']');

                        int indexofstring = lines[i].IndexOf("[ClassID:");
                        //get name of item
                        string itemname = lines[i].Substring(0, indexofstring);
                        itemname = itemname.TrimEnd().ToLower();

                        //set name of item
                        item.name = itemname;
                        //test code
                        //Console.WriteLine(item.name);
                        lines[i] = lines[i].Substring(indexofstring);



                        //class id
                        indexofopen = lines[i].IndexOf('[');
                        indexofclose = lines[i].IndexOf(']');


                        string classid = lines[i].Substring(indexofopen + 9, indexofclose - indexofopen - 9);
                        classid = classid.TrimStart();
                        item.classid = int.Parse(classid);
                        lines[i] = lines[i].Substring(indexofclose + 2);
                        //Console.WriteLine(lines[i]);

                        //xpos
                        indexofopen = lines[i].IndexOf("X:");
                        indexofclose = lines[i].IndexOf("Y:");
                        string Sxpos = lines[i].Substring(indexofopen + 2, indexofclose - indexofopen - 3);
                        Sxpos = Sxpos.TrimStart();
                        int xpos = int.Parse(Sxpos);

                        item.xpos = xpos;
                        //Console.WriteLine(item.classid.ToString());


                        //y pos
                        indexofopen = lines[i].IndexOf("Y:");
                        indexofclose = lines[i].IndexOf(")");
                        string SYpos = lines[i].Substring(indexofopen + 2, indexofclose - indexofopen - 2);
                        SYpos = SYpos.TrimStart();
                        int ypos = int.Parse(SYpos);
                        item.ypos = ypos;
                        item.masterstring = lines[i].ToLower();
                        //reforge
                        if (lines[i].Contains("Reforge"))
                        {

                            if (lines[i].Contains("[Transforming]"))
                            {
                                lines[i] = lines[i].Replace("[Transforming] ", "");
                            }
                            indexofopen = lines[i].IndexOf("Reforge");
                            lines[i] = lines[i].Substring(indexofopen);
                            indexofopen = lines[i].IndexOf("Reforge");
                            indexofclose = lines[i].IndexOf("]");

                            lines[i] = lines[i].Substring(indexofopen + 8, indexofclose - indexofopen - 8);
                            Console.WriteLine(lines[i]);
                            string reforgelevel = lines[i].Substring(0, 3);
                            reforgelevel = reforgelevel.Replace("Lv", "");
                            item.reforgelevel = int.Parse(reforgelevel);

                            if (lines[i].Contains(','))
                            {
                                string[] reforges = lines[i].Split(',');

                                for (int j = 0; j < reforges.Length; j++)
                                {
                                    reforges[j] = reforges[j].TrimStart().ToLower();
                                    Console.WriteLine(reforges[j]);

                                }
                                item.reforges = reforges;
                            }

                            //


                        }



                        x.MyList.Add(item);
                    }

                }
            }
            chara.Add(x);

        }
    }
}
