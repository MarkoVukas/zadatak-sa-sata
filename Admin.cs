using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Admin
    {
        public static void SaveBook(string zapis)
        {
         using(StreamWriter sw = new StreamWriter("knjige.txt", true))
            {
                sw.WriteLine(zapis);
                sw.Close();
            }
        }
        public static List<string> SearchByTitleOrAuthor(string kriterij)
        {
            List<string> rezultati = new List<string>();
            if(File.Exists("knjige.txt"))
            {
                using(StreamReader sr = new StreamReader("knjige.txt"))
                {
                    string linija;
                    while((linija = sr.ReadLine()) != null)
                    {
                        string[] dijelovi = linija.Split(';');
                        if (string.Equals(dijelovi[0], kriterij)==true || string.Equals(dijelovi[1],
                            kriterij)==true)
                        {
                            knjige.Add(linija);
                        }
                    }
                    sr.Close();
                }
            } return knjige;
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> knjige = new List<string>();
            if(File.Exists("knjige.txt"))
            {
                using(StreamReader sr = new StreamReader("knjige.txt"))
                {
                    string linija;
                    while((linija = sr.ReadLine()) != null)
                    {
                        knjige.Add(linija);
                    }
                    sr.Close();
                }
            } return knjige;
        }
        public static List<string> GetCountByGenre()
        {
            string knjige;
        }
    } 

}
