using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
            //void on andmetüüp, mida muutuja tekitamisel kasutada ei saa. kasutatakse ainult meetodite signatuurides väljendamaks et

            /* Võimalikud komposiitandmetüübid */
            // 1. massiiv:
            // [] - > massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistakse kantsulgudega.
            //        massiiv saab olla üksikõik millist lihtandmetüüpi massiive.
            //        massiivi tekitamisel tuleb ära öelda kui suur see massiiv on.
            //        massiiv ei pea olema koostatud ainult lihtandmetüüpidest,  vaid massiive saab olla ka tehtud teistestkomposiitandmetüüpidest
            //        Sealhulgas massiiv ise.
            // Esimene tekstitusviis:
            int[] arvuMassiiv = new[3]; // andmetüüp int et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et ühitlasi on
                                        // tegu ka massiiviga. muutuja nimeks in "arvuMassiiv" ja võrdusmärgi abil on omistatud muutujasse
                                        // uus tühi massiiv kasutades kaitstudes kaitstud sõna "new", millele järgneb selle massiivi andmetüübi ja
                                        // pikkuse sätestus "int[3]". See tähendab et siin massiivis on 3 elementi, mis on täisarvud.
                                        // Teine tekitusviis:
            int[] arvuThisMany = arvuMassiiv.Lengeth;  // teine massiivi tekstusviis kus järjendi pikkuse sätestamise asemel, pannakse elemedu´id kohe
                                                       // mitu elementi, adresseeritav massiiv omab, omistatakse ainult järjendi
                                                       // järjendi sees olevaid elemente.
                                                       //põhilised matemaatilised tehted
                                                       int liitmine =
                                                       //


            //Matemaatilised tehted moodulist "Math"
            double astendamine = Math.Pow(2, 2); //astendamine, esimine arv astendatakse teisega
            double juurimine = Math.Sqrt(2); //ruutujuur, parameetrina juuritav arv
            double NewD = 4.0000000d;
            Math.Round(NewD);  //Moodulist "Math" kutsutakse esile punkti abil meetod "Round", sulgude vahel on esimese parameetrina
                               //ümardatav arv, teise parameetrina komakohtade arv. round ümardab sulgude
                               //teises parameetris oleva komakohtadeni.Kui komakohti ei ole seatud, ümard
                               //0-4 ümardatakse allapoole, 5-9 ümardatakse ülespoole.
                               double newPI = Math.PI; //Moodulist "Math" kutsutakse punkti abil esile kaitsud väärtus, PI
            // maatilist pi-d ja seda saab kasutada nagu tavaline arv.

            //Castimine, ehk arvu teisendus ühest andmetüübist teise

            //Castimine on viis, kuidas ühest andmetüübist teist saada, Castimist ennast kahte eri liiki - Automaatne ja
            //manuaalne. Automaatne toimub siis, kui teisendatakse väiksemat andmetüübist suuremasse, aga manuaalselt
            //on vaja castida siis, kui üritame suuremast andmetüübist väiksemat saada. Manuaalne castimine käib nii, et
            //sihtmuutuja võrdusmägi taga oleva muutuja nimetuse ette, pannakse sulgudes soovitava andmetüübi nimetus.

            double newData1 = 1.23d; //tekitame, või on kuskil olemas, suure andmed muutujas "newData1" kus on tehu double
                                     //andmetüübiga
            float data1float = (float)newData1; //"(float)" teisendab tüüpi andmed float tüüpi andmeteks.
            long data1Long = (long)newData1; //"(long)" teisendab double tüüpi andmed float tüüpi andmeteks.
            int data1Int = (int)newData1; //"(int)" teisendab double tüüpi andmed täisarvu andmeteks tüüpi andmeteks.
            char data1Char = (char)newData1; //"(char)" teisendab double tüüpi andmed char tüüpi andmeet
       
                
                                  

            //2. Loend:
            // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
            //            täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse <> asetatakse mis tüüpi andmed seal loendis on.
            //            Loendi tekitamisel, erinevalt massivist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elementi juurde lisada,
            //            ehk tema pikkus ei ole fikseeritud. Sarnaselt massiiviga saab temas hoida ka teisi londeid.
            // Esimine tekitusviis:
            int arvuNimekiri;
            List<int> arvu = arvuNimekiri = new List<int>(3); //Andmetüübi kirijeldus "List<>" näitab et tegu on loendiga. List noolsulgude <> vahel on loednis
                                                             //olevate andmete andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. Muutuja enda
                                                             //nimiks on "arvuNimekiri". Omistame sellesse muutujasse kaitstud sõna "new" abil uue tühja
                                                             //täisarvuloendi sätestusega "List<int>()".
            // Teine tekitusviis:
            List<int> arvuNimekiri2 = new List<int>() {1,2,3 }; //Teine loendi tekitusviis. Andmetuubi kirjeldus "List<>" naitab et tegu on loendiga, Listi
                                                                //noolsulgude vahel on loendis olevate elementide andmetuup. Antud juhul on andmetuubiks "int"
                                                                //mis tahistab taisarve. Muutuja enda nimeks on "arvuNimekiri2". Omistame selle muutujasse
                                                                //kaitstud sona "new" abil uue taisarvuloendi, aga seekord, peale satestust "List<int>()" saame
                                                                //instantsieerimise hetkel talle kaasa anda ka esimesi elemente. Antud juhul on need elemendid
                                                                //"1", "2" ja "3". Elemendid sisestatakse nimekirja loogeliste sulgude vahel. Enam ei ole tegu
                                                               //tuhja nimekirjaga, vaid loendiga kus on kolm elementi juba sees.
            //kolmas tekitusviis:
            List<int> arvuNimekiri3 = new List<int>(3);      // kolmas tekitusviis:
                                                             //Kolmas loendi tekitusviis. Andmetuubi kirjeldus "List<>" naitab et tegu on loendiga, Listi noolsulgude
                                                             //vahel on loendis olevate elementide andmetuup. Antud juhul on andmetuubiks "int" mis tahistab taisarve.
                                                             //Muutuja enda nimeks on "arvuNimekiri3". Omistame sellesse muutujasse kaitstud sona "new" abil uue
                                                             //taisarvuloendi, aga tavaliste sulgude vahele paneme arvu "3". Sarnaselt massiiviga utleb see, et
                                                             //loend on 3 elemei urung. Loend ise ja tema elemendid on tuhjad, aga seal on 3 elementi. Arv "3"
                                                             //on parameeter mida Listi konstruktor pikkuse maaramiseks kasutab. Nimekiri sailitab oma omaduse muuta
                                                             //pikkust elementide lisamise-eemaldamisega, aga vajadusel saab nii anda talle pikkuse.
            int aa = 9001;
            // -- Loendi sisemised meetodid:
            arvuNimekiri.Add(99); //Loendi meetod "Add()" lissab enne punkti olevale järgmile uue elemendi, mida lisatakse Add meetodi sulgude
                                  //Vahel. Elementi sasab lisab lisada otse (antud juhul täisarv "99")
            arvuNimekiri.Add(aa); //või muutujana.
            int loendiPikkus = arvuNimekiri3.Count(); // Loendi meetod "Count()" loeb kokku mitu elementi järjendis on, meetod tagastab täisarvu mis vastab
                                                      //elementide kogusele
            bool KasSeeArvOn = arvuNimekiri3.Contains(3); //Loendi meetod "Contains()" otsib kogu järjendis on, meetod tagastab täisarvu mis vastab
                                                           //parameetrile. Meetod tagastab kas "true" või "false" - on leitud või ei ole.Tegemist on
                                                           //põhimõtteliselt foreach tsükliga, mis otsib kindlat vastet, töötades läbi kogu loendi.
            arvuNimekiri3.Remove(4); //Loendi meetod "Remove()" eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulgude vahel on parameetriks
                                     //ee,aldava elemendi asukohajärjekorranumber.

            int liitmine = 1 + 1; //liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; //lahutamine, kus esimesest arvust lahutatakse maha teine
            double korrutamine = 1 * 2; //korrutamine, kus teine arv korrutatakse esimese arvu kordi.
            double jagamine = 1 / 2; //jagamine. esimene arv jagatakse teise arvuga.
            double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
            double juurimine = Math.Sqrt(2); //ruutjuur, parameetrina juuritav arv
                                             //muutuja nimed
            int arv = 0; //sobib
            string sõne = "abc"; //sobib
                                 //string string = "abc"; //kaitstud sõna kasutada ei saa


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

            Console.WriteLine("sisesta");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("saada 20% allandlust!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("saad 10% allahindust. c: yay");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusumma < 21 && ostusumma > 0)
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestatud on vigane arv");
            }

            /* tingimuslause osad */
            if (true) { } //kaitstud sõna "if" kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
                          //koodiplokk tingimuse täitumisel teostatav koodiga
            else if (true) { } // laitstud sõnad "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                               //on samamoodi sulgude vahel, ning millele pepab eelnema alat kas "if" või teine "else if". tingimuse täitumisel
                               //ja eelneva tingimuse mittetäitumisel, teostatakse koodiploki sees olev kood.
            else { }       //kaitsud sõna "else" kutsub esile järeltingimuse, mille peab eelnema kas "if" võ "else if", ning mille koodiploki sisu
                           //täidetakse kõikide teiste "if" ja "else if" tingimuste läbikukkumisel.

            /* loogilised tehted */

            // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse (true= juhul kui
            //        mõlemal poll "&&" märki olevad tingimused on täidetud. kui üks neiste ei ole, siis annab negatiivse (false).
            // || -> "or"! loogiline tege, mida kasutatakse tingimuste kirjendamisel, ning mis annab positiivse vastuse (true) siis kui
            //        vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimuse on täitmata.
            //! -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus, mis muidu tagastaks (true),
            //      hüüumärgi abil tagastab (false), ja vastupidi - tulemus mis muidu tagastaks (false), hüüumärgi abil tagastab (true)

            /* võrdlusoperaatorid */

            // == -> "on võrdne" võrdusmäride ühel pool olev peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //        objektiga. ei ole sama nagu üks võrdusmärk omistab, kaks võrdleb.
            // != "ei ole võrdne". Võrdusmärgi ühel pool olev objekt */EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool oleva
            //    Ta võib olla üksikõik mis mul kujul, aga mitte võrreldava objektiga samal kujul. võrdlusoperaator on kombinatsioon
            //    "on võrdne operaatorist, ja loggilisest tehtest "not".
            // >    -> "on suurem kui". Märgist vasakul pool olev objekt peaks olema suurem, kui paremal pool olev objekt.
            // <    -> "on väiksem kui". Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
            // >= -> "suuremvõrdne". märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
            //       võrdlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest-
            // <= -> "väiksemvõrdne". Märgist vasakul pool olev objekt peaks olema vähemaöt võrdne või väiksem kui parempoolne objekt.
            //       võrdlusoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

            /* omistusoperaatorid ja kiirthehted */

            int thing = 1;// 0  -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
            thing += 1;   //  += -> võrdusmärki mille ees on pluss automatselt liidab muutujale otsa võrdusmärgi teise pool oleva arvu.
                          //         asendab tehet "thing = thing + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
            thing -= 1;   // -= -> võrdusmärk mille ees on miinus , automatselt lauhtab muutujast maha võrdusmärgi teisel pool oleva arvu.
                          //        asendab tehet "thing = thing - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "="
            thing *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool
                          //       oleva arvu kordi. asendab tehett "thing = thing * 2". on kombunatsioon matemaatilisest tehtest "*" ja
                          //        omistamisest "=".
            thing /= 2;   // /= ->  võrdusmärk mille ees on jagamismärk "/", automatselt jagab muutuja sise võrd


            /* Tsüklid */
            // 1. do-while
            int dew = 0;
            do // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärst seda on koodiplokk {} ning ütleb et tee seda koodi
            {
                dew++;
            } while (dew != 5); //niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.

            // 2. while
            int i = 1;    //tsüklimuutuja mis aitab järge pidada while tsükli toimimisel
            while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab alati välist
                          //tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel,
                          //siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
                          // antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel
                          //katkeb.
            {
                //koodiplokk kus midagi tehakse
                i++;      //ning seejärel muudetakse tsüklimuutuja "i" olekut. antud juhul liidetakse 1 juurde kiirtehtega "++".
            }

            //3. for
            int kogus = 6; // muutuja mida kasutab oma töö tegemiseks + teisisõnu, töödeldav materjal
            for (int k = 0; k < kogus; ++k) // kaitstud sõnaa "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli
                                            // töö jaoks vajalik olemas. Esimene parameeter, tekitab tsükli tõõ jaoks kohaliku muutuja
                                            // "int k = 0;" mida tsükli ENDA töö juhtimiseks. Teine parameete on tingimuslause, mis kontrollib
                                            // tingimuse täitmist "k < kogus;" ning mille täitumisel tsükli töö jätkub, aga mille
                                            // mitte-täitumisel tsükkel katkeb. kolmas parameeter on tsükli töö jätkub, aga mille
                                            // mitte´-täitumisel tsükkel katkeb. kolmas parameeter on tsükli töö jätkub, aga mille
                                            // mitte-täitumisel tsükel katkeb. kolmas parameeter on tsüklimuutuja ink rementeerimine kiiretehtega
                                            //"k++". Pare tähele, et iga sulgude vahel oleva osa järel (välja arvatud viimase) on
                                            // lauselõpumärk. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest
                                            // nagu "while" või "do-while" puhul.

                //4. forech
                int[] arvuLoend = { 3, 67, 420, 69, 42 }; //massiiv mida foreach kasutab või tööleb mingil kujul
            foreach (var arvInLoend in arvuLoend) //kaistud sõna doreach alustab tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                                  //ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                                  //kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend"
                                                  //muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nätasvat
                                                  //tsüklimuutujat ega tingimust, tsükkel toimub niikaua kuni elemmente jätkub, ehk tsükli töö käib
                                                  //iga üksiku elemendi kohta andmekogumis individuaalselt. Tsüklil ei ole vaja tsüklimuutujat , kuna talle on
                                                  // sisse ehitatud vaikimisi elemendi järestuse järgimine.Niipalju kui andmeid loendis on, ongi see
                                                  //mis ütleb ära, mitu korda tsükkel käivitatakse



                








        }
    }
    /* Meethod */

    // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid spetsiifilisi funktsioone             
    // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
    // Meetodeid on kahte liiki - Ühed, mis tagastavad mingisuguse töö või tegevuse tagajärjel või tulemusena
    // mis ei tagasta midagi, kuid omavad siiski mingit tegevust.

    // Metodi singnatuur & selle kompositsioon:
    // Metodi sinatuur on kõige esimine rida, mis meetodi tekitamiseks kirjutatakse, ning mis kirjeldab meetodit ennast, ning selle
    // omadusi.
    // Meetodi signatuur koosneb kindlast äramääratud omadusest. nendeks on juurdepääsu modifikaator, tagastustüüp,
    // meetodi enda nimi, olenevalt meetodi liigist ka parameetrid mis on sulgude vahel (), ning koodiplokist mis on meetodi sisu.
    // - Juurdepääsu modifikaator ütleb ära, kust ja kuidas seda meetodit välja kutsuda või adresseerida saab. Juurdepääsu modi-
    // fikaatoreid on tähtsamatest 4-5 tükki.
    // 1 - üublic --- meetod on avalik ja kättesaadav ka teistes klassi, kus meetod ise asub.
    // 2 - private --- meetod on saadav ainult selles klassis kus meetod ise asub.
    // 3 - protected --- meetod on saadav ainult selles klassis kus meetod ise asub ja klassis mis pärilusega saab
    //     selle klassi andmed kaasa.
    // 4 - internal -- meetod on saadav ainult selles klassis ja ainult selles gailis.
    // 5 - static --- vahest võib olla pandud ka static, see ütleb lihtsalt et see meetod asub siin.
    //
    // - Tagastustüüp on meetodi omadus, mis ütleb ära mis tüüp andmed, meetodi väljakutsumise asukohta tagastatakse, kui üldse.
    // Andmetüüp, mida tagastada, võib olla ükskõik milline liht- või kombinatsioonandmetüüp. Aga kui ei tagasta üldse andmeid
    // pannakse selle asemel andmetüübiks "void". kui meetodil on tagastustüüp mis on midagi muud kui void, on meetodi sees, iga toimiva
    // koodisuuna lõpus kaitstud sõna "return", return ütleb, et just see asi on vaja tagastada.peale returni on alati mingisugune kindel
    // muutuja, või tegevuse tulemus, mis tagastatakse meetodi väljakutseasukohta. peale käivitatud returni, ei teostata mitte ühtegi
    // muud meetodis olevat koodi, sest meetod on leidnud oma tagastatava objekti, ning meetodi töö sellel hetkel katkestatakse.
    // Return on osaliselt ka kui break.
    //
    // - Meethod enda nimi on midagi mille järgi arendaja meetodit kasutab koodis välja, ning meetodi nimi peaks kuvama
    // üldsõnaliselt mida see meetod teeb. Näites meetod nimega "A();" ei ole hea, sest sõna "A" ei ütle programmerijale mitte midagi.
    // Aga näiteks meetod, nimega "arvutiKokku();" Ütleb arendajale ära, mida see meetod teeb. Ta ei raiska oma aega, selle
    //* meetodi enda koodi lugemisele.
    //
    // - Parameetrid on need, mis ütlevad, mis meetodil tema tääks vaja on. Parameeter, meetodi signatuuris võib olla teistmoodi
    // väljendatud, kui on kirjutatud muutuja mis on koodi sees, mille jaoks seda kasutada vaja on.
    // 1. tüüp meetod - ei tagasta midagi:
    public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb et ta kuulub sellesse
    {                               //klassi. tagastustüüp on "void" mis ütleb etandmeid meie meetod ei tagasta. pärast omadusi on selle
                                        //meetodi nimi "UusMeetod" peal mida on sulud, kus parameetreid ei ole.
                                        //pärast signatuuri on koodiplokk selle meetodi koodiga, loogeliste sulgude vahel {}

            
      Console.WriteLine("Tere");   //antud juhul on meetodi sisuks sõnumi kuvamine, mooduli "Console" abiga, mille seest punkti abil "."
                                   //adresseerime Console meetodit "WriteLine" ning mille parameetriks on sõne "Tere", parameeter asub
                                   //see arendaja nimi olevate sulgude vahel. Lause lõppeb lauselõpumärgiga ";"
                                   //see arendaja poold kirjutatud meetodi koodi ei oma.
    }

        // 2. tüüpi meetod - tagastab väärtuse:
        int[] arvutatavadAravud = new int[] { 67, 69, 420, 9001 }; //Töödeldavad andmed, mis asuvad täisarvumassiives, muutujanimega
                                                                   //"arvutatavadArvud".

        public static int Arvutakokku(int[] arvutatavad) //Meetod mille ssignatuuris on juurdepääsumodifikaator "public", "static" ütleb et ta kuulub
                                                         //sellesse klassi, tagastustüüp "int" ütleb, et programmis tagastatakse täisarv asukohta
                                                         //koodis kus meetod algelt välja kutsuti. siis on meetodi nimi "ArvutaKokku", ning sulgude
                                                         //vahel ootab meetod täist
    }