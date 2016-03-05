using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace codekata8
{
    class Program
    {
        public static List<string> DicList;
        public static List<string> DicListSeis;

        static void Main(string[] args)
        {
            DicList = new List<string>();
            DicListSeis = new List<string>();
            CargarDiccionario(@"C:\codekata\wordlist.txt");
            BuscarEnDiccionario(); 
        }

        public static void BuscarEnDiccionario()
        {
            String palabra;

            foreach (var primeraPalabra in DicList)
            {
                foreach (var segundaPalabra in DicList)
                {
                    palabra = primeraPalabra + segundaPalabra;
                    if (palabra.Length == 6)
                    {
                        if ((DicListSeis.FirstOrDefault(x => x == palabra) ?? "").Length > 0)
                        {
                            Console.WriteLine(primeraPalabra + " + " + segundaPalabra + " => " + palabra);
                        }
                    }
                }
            }
        }

        public static void CargarDiccionario(string filename)
        {
            if (File.Exists(filename))
            {
                string linea;
                StreamReader file = new StreamReader(filename);
                FileInfo fileInfo = new FileInfo(filename);

                while ((linea = file.ReadLine()) != null)
                {
                    DicList.Add(linea);
                    if (linea.Length == 6)
                        DicListSeis.Add(linea);
                }
                file.Close();
            }
        }
    }
}
