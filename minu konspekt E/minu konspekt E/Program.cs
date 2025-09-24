using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace minu_konspekt_E
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");

            //muutujad, matemaatilised tehted, IF ; ELSE IF JA ELSE:

            //1 tuvasta sisu võrdluses null" ga
            Console.WriteLine("tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == null)
            {
                Console.WriteLine("tere " + nimi + "!");
            }
            else if (nimi != "")
            {
                Console.WriteLine("kasutaja ei sisestanud oma nimi");

            }
            else
            {
                Console.WriteLine("kasutaja ei sisestanud oma nimi");
            }

            //2.tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + ", mis on sinu vanus?:  ");
            int kasutajavanus = int.Parse(Console.ReadLine());
//           
//           //2.1 mitu tingimust pesastatud if-abil
//            if (kasutajavanus == 0)
//            {
//                Console.WriteLine("kahjuks energiajooki sulle ei müüda, oled monsterist ilma");
//            }
//            else
//           {
//                Console.WriteLine("saad osta monsterit, YIPPIE");
//           }
//{

             //2.2 mittu tingimust ühe ifi sees kasutades loogilist 
             if (kasutajavanus > 0 && kasutajavanus < 18)
             {
                Console.WriteLine("kahujuks energiajooki sulle ei müüd, oled monsterist ilma");
             }
            else
            {
                Console.WriteLine("saad osta monsterit, YIPPIE");
            }
             //2.3 mitu vahemikku, if-elseif, double/float
             Console.WriteLine("sisesta oma pikkus ka, palun, "+nimi+":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("oled juntsu");
            }
            else if (pikkus <1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("olde peaaegu allameetrimees");
            }
            else if (pikkus <1.50 && pikkus >1.25d)
            {
                Console.WriteLine("oioi, päkapikk enam ei olegi "+nimi+" !");
            }
            else if (pikkus <2.00d && pikkus >1.75d)
            {
                Console.WriteLine("pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
            }
            else if (pikkus >2.00d)
            {
                Console.WriteLine("täielik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pkkust ei tunta");
            }




            //4 parool, if ja string andmetüüp
            Console.WriteLine("programmi edasiseks tööks sisesta palin parool:");
            string password = Console.ReadLine();

            if (password == "simsalabim")
            {
                Console.WriteLine("parool on õige, aarete laegas avaneb");
            }
            else if (password == "saatan" || password == "1234")
            {
                Console.WriteLine("parool on sobimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("parool on vale, proovi uuesti");
            }

            //5 värvituvastus
            Console.WriteLine("milline värv sulle kõige rohkem meeldib?:");
            string favoritecour = Console.ReadLine();
            if (favoritecour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (favoritecour =="orange")
            {
                Console.WriteLine("kahjuks organzi ei ole");
            }
            if(favoritecour =="kollane")
            {
                Console.BackgroundColor= ConsoleColor.Yellow;
            }
            if (favoritecour =="rohaline")
            {
                Console.BackgroundColor= ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("värvi ei tunne");
            }
            Console.WriteLine("värv muudetud!");




