using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnorderedList
{
    class ReadAllText
    {
        public void Read(string path)
        {
            string line;
            try
            {
                line = File.ReadAllText(path);
                Console.WriteLine(line);
                string[] wordlist = line.Split();
                LinkedList<string> list = new LinkedList<string>();
                foreach (string ele in wordlist)
                {
                    list.AddFirst(ele);
                }

                foreach (string ele in list)
                {
                    Console.WriteLine(ele);
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

        }
    }
}
