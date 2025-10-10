using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
            Console.WriteLine("sisesta oma pikkus ka, palun, " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("oled juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("olde peaaegu allameetrimees");
            }
            else if (pikkus < 1.50 && pikkus > 1.25d)
            {
                Console.WriteLine("oioi, päkapikk enam ei olegi " + nimi + " !");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
            }
            else if (pikkus > 2.00d)
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
            if (favoritecour == "orange")
            {
                Console.WriteLine("kahjuks organzi ei ole");
            }
            if (favoritecour == "kollane")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (favoritecour == "rohaline")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("värvi ei tunne");
            }
            Console.WriteLine("värv muudetud!");


            Console.WriteLine("hapukapsas");
            // "console"         om moodle C# mida me adresserime, Console aitab teha tegevusi käsureal
            // .                näitab, et meil on vaja adresseerida mingisugust funktsiooni või meetodit
            //                  mooduli "console" seest.
            // "writeline"      funktsioon mida me parasjagu kasutame.
            // ()                sulupaar mis omab funktsiooni tööks vajalikku infot.
            // []                tähistab massive
            // {}                 koodiplokk, tavaliselt kas pärast (if, else if) tingimust, mamespacei või funktsiooni kirjeldust
            // "hapukapsas"     parameetel mis antakse funktsioon write.line töötlemiseks kaasa.
            //                taane aitab arendajal aru saada, kuskohas millise koodiploki sees kood
            //ajalik ka kompolaatorile samal eesmärgil.                
            // ;              kõik koodilaused lõppevad komakoolomga, mis tähistavad lause lõppu
            // //             tähistab üherealist kommentaari
            // /**/           tähistab mitmerealist kommentaari või kommentaariregiooni

            int muutuja = 3;
            // int           on muutuja nime ees olev andmetüübi kirjeldus mis näitab ära , millist
            //                tüüpi andmed selle muutuja sees on.
            // "mutuja"        on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava
            //                sõnaga, ja mille anil saab heid addresseerida koodi sees.
            // =              üksik võrdusmärk omistab muutuja sisse vastav väärtuse mis asub
            //                teiselpool võrdusmärki.
            // 3              mutujale omistav väärtus.         

            /* võimalikud andmetüübid mida vaja võib minna: */
            int a = 1; // int on täisarv
            decimal b = 2.1M; // decimal on kümnedsüsteemis olev komakohaga arv
            float c = 3.9f; // float on 32-bitine komakohaga arv
            double d = 5.6d; // double on 64-bitine komakohaga arv
            char c1 = 'a'; // üksainus täht või tähemärk mis tähistatakse ülakomadga ""
            string s = "tekst"; //tähtedest koosnev sõna või tekst, tähistatakse jutmärkidega ""  
            var x = "abc"; //var on ebamäärase andmetüübiga kohalik muutuja
            var y = 123;   //ta võib omada endas teisi andmetüüpe
            const int z = 9; // konstat-tüüpi muutujaid ei saa muutu, nende sisu on read-only

            //põhilised matemaatilised tehted
            int liimine = 1 + 1; // liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; // lahutamine, kus esimisest arvust lahutatakse maha teine
            double korrutamine = 1 * 2; //korrutamine, kus teine arv korrutatakse esimine arvu kordi.
            double astendamine = Math.Pow(2, 2); //astendamine, esimine arv astendatakse teisega
            double juurimine = Math.Sqrt(2); //ruutjuur, parameetrinajuuritav arv

            //muutuja nimed
            int arv = 0; //sobib
            string sõne = "abc"; //sobib             
                                 //string string = "abc"; //kaitstud sõna kasutada ei saa

            // muutuja nimeks ei sobi järgnev sõnad:
            // abstract, as, base, bool, break, byte,case,
            //catch, char, checked, class, count, contine, decimal,
            //default, delegate, do, double, else, enum, event,
            //explict, extern, false, finalyy, fixed, float, for
            //foreach, goto, if, imlicit, in, int, interface, internal
            //is, lock. long, namespace, new, null, object, operator,
            //out, overrid, params, private, protected, public, readonly,
            //ref, return, sbyte, sealed, short, sizeof, stackalloc,
            //unit, ulong, unchecked, unsafe, ushort, using, virtual,
            //void, volatile, while.

            //3 kalkulaator ifi ja elsifidega 
            Console.WriteLine("Lihtne kalkulaator ");
            Console.WriteLine("-----------------------");
            //adresserime moodulit "console", punkti abil ütleme, et kasutame gunktsiooni writeline
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            //ümbritsetuna jutumärkidaega. Kasutajale esitatav sõnum on "Tere. Sisesta esimine arv"

            // Esimese numbri sisestamine
            Console.Write("Sisestage esimene number: ");
            double num1 = double.Parse(Console.ReadLine());
            //instantsieerime muutuja nimega "arv1", ning selle ette anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil 
            //väärtuse, mille saame kasutajalt. selle jaoks, adresseerime uuesti "console" moodulit
            //Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv progreammile
            //tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "parse", ning paneme
            //ReadLine funktsiooni Parse() sulgude vahel.

            // Teise numbri sisestamine
            Console.Write("Sisestage teine number: ");
            double num2 = double.Parse(Console.ReadLine());
            //adresserime moodulit "console", punkti abil ütleme, et kasutame gunktsiooni writeline
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            //ümbritsetuna jutumärkidaega. Kasutajale esitatav sõnum on "Tere. Sisesta esimine arv"


            // Tehte sisestamine
            Console.Write("Valige tehe (+, -, *, /): ");
            //Adresserime moodulit "console" koos "WriteLine" funktsiooniga, et esitada kasutajale
            //küsimuse "Sisesta tehtemärk: / * + -". Punkti abil saame moodulist Console, funktsiooni
            //WriteLine, ning sulgude vahel ongi kasutajale esitajale esitatav tekst. ise on ka ümbritsetud
            //jutumärkidega. Lause lõppeb lauselõpumärgiga ";"

            string operation = Console.ReadLine();
            //instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string"
            //Omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
            //"console" moodelis olev ReadLine() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".

            double result = 0;
            //instantsieerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algseõ
            //väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".



            // Kontrollime tehet
            if (operation == "+")
            //teeme tingimuslause if, ning selle tingimuse määrrame ära sulgudega, mille vahel on
            //võrdsuskontroll. Kontrollime kas muutuja "tehtetypp" omab andmeid samal kujul
            //nagu võrdusmärkidest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
            //ole koodiga mis midagi kindlalt veel ära teeb.
            {
                result = num1 + num2;
            }
            //peale tingimest on koodiplokk {} sulgude vahel, mis sialdab andas ühte koodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmestehte tulemuse,
            //lus liidame muutuja "arv1" ja muutuja "arv2" sisu.Lause lõppeb lauselõpumärgiga ";".

            else if (operation == "-")
            //teeme sekubdaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
            //Sulgude vahel on võrdsuskontroll. kontrollime kas muutuja "tehtetypp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei
            //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                result = num1 - num2;
            }
            //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
            //koodirida. sellse lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehte
            //tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas
            //oleva väärtuse. Lause lõppeb laselõpumärgiga ";".
            else if (operation == "*")

            //teema sekundaarse tingimuslause "else if", ning määrasse tema tingimus ära sulgudega.
            //sulgude vaheöl on võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus e'i
            //täitunud. Lause siin ei lõppe vaid tingimusele järgneb koodiplokk.
            {

                result = num1 * num2;
            }
            //peal tingi,ust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab ühte
            //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            //tulemuse, kus jagame muutujas "arv1" oleva väärtuse; muutujas "arv2" oleva jagajaga
            //Lause lõppeb lauselõpumärgiga ";".

            else if (operation == "/")
            //teeme sekundaarse tingimuslause "else if ", ning määrame tema tingimuse ära sulgudega.
            //Sulgude vahel on võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid
            //samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei 
            //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab andas ühte
                //koodirida. selles lauses imstame muutujale "tulemus" võrdusmärgi abil korrutustehte
                //tule,use, kus korrutame muutujas "arv2" oleva väärtus muutujas "arv1" oleva väärtuse
                //kordi. Lause lõppeb lauselõpumärgiga ";".
                else
                   //teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
                   //Sulgude vahel on võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid
                   //samal kujul nagu võrdusmärkidest teisel pool olev tekst "^" kui eelnev tingimus ei
                   //täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
                {
                    Console.WriteLine("Viga: nulliga jagamine ei ole võimalik!");
                    return; // lõpetame programmi
                }
                //peal tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
                //koodirida. sellas lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
                //"Math" moodulist pärineva funktsioni "pow()" abil. Math.pow() võtab parameetritena
                //sisse muutujad "arv1" ja "arv2". Esimine parameeter omn astendatav, teine parameeter
                //om astedaja, Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja
                //"tulemus" andmetüüpm on täisarv . Math.Pow() ees om kiirteisendus (int), kuna muutuja
                //"tulemus" andmetüüp on täisarv. Math.Pow() väljnd teisendatakse ni täisarvuks.
                //Lause lõppeb lauselõpumärgiga ";".
            }
            else
            //peale kõiki järeltingimusi on meil. tingimuslause osa "else" mida täidetakse kõikede
            //muude tingimuslause osada mittetäitumisel. Siin ealdi tingimust välja ei kirjutada
            //ning sellest tulenavalt ei ole ka sulge. järgneb ainult koodiplokk.
            {
                Console.WriteLine("Tundmatu tehe!");
                return;
            }
            //pelse "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodirida. Selles koodireas kasutame moodulist "Console" punkti abil funktsiooni
            //oskab". Koodirida lõpeb lauselõpumärgiga ";".


            // Tulemuse väljastamine
            Console.WriteLine($"Tulemus: {num1} {operation} {num2} = {result}");
            //kasutame moodulist "Console" punkti abil funktsioono "WriteLine" et kuvada kasutajale
            //tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga ";".
        }
    }
}