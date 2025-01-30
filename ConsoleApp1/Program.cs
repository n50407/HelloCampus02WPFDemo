using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        delegate void HelloFirstnameDelegate(string name);
        //class HelloFirstnameDelegate
        delegate void HelloDelegate(string anrede, string name);
        delegate void HelloDelegateMitInt(string anrede, string name, int x);


        public static void Ausgabe(Action myFunctionWithoutArgs, int wieOft)
        {
            for (int i = 0; i < wieOft; i++)
            {
                myFunctionWithoutArgs();
            }
        }
        static void Main(string[] args)
        {

            Ausgabe(
                ()
                =>
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("schönes Wochenende");

                        }, 
                4
                );

            Ausgabe(
                ()
                =>
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bis Donnerstag");

                },
                2
                );



            var color = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow");
            Console.BackgroundColor = color;

            /*
            //Lösung mit Lambda und Action-Delegate
            Ausgabe(WAS in Form einer Lambda-Expression, WieOft als Zahl);
            //WAS --> Schönes Wochenende in Rot 4x
            //WAS --> Bis Donnerstag in Gelb 2x

            Ausgabe(......){
                for(int i=0; i<Zahl; i++){
                    f() ;
                }
            }*/


            //
            //Start with STRG +F5
            Console.WriteLine("Hello from the console");
            //
            HelloFirstname("Ajla");
            int a = 12;
            //Deklaration einer Delegate-Variable
            //Zuweisung einer Methode - WICHTIG OHNE ()
            HelloFirstnameDelegate myHello = HelloFirstname;
            myHello("Ajla"); //Aufruf über das Delegate
            Hello("Hello", "Chrisi");
            HelloDelegate myHello2 = Hello;
            Hello("Hello", "Chrisi");
            Action<string> a1 = HelloFirstname;
            Action<string, string> a2 = Hello;
            a1("Hans");
            a2("Hello", "Hans");
            HalloMitLogik(Hello, "Hallo", "Chrisi");
            HalloMitLogik(HelloMitBinde, "A", "B");
            HalloMitLogik(HelloMitStrichpunkt, "X", "Y");
            HalloMitLogik(HelloMitSlash, "X", "Y");

            //Lambda
            HalloMitLogik(
                (an,vor) => 
                { 
                       Console.WriteLine(an + "__" + vor); 
                }, 
                "Hallo", 
                "Chrisi");


            //() =>{Code
            //Console.ReadLine(); //Warte ein Eingabe

        }

        //CalcMethode(Logik, Zahl1, Zahl2, Operator)
        //Das Ergebnis von 17 + 9 = 
        public static void HalloMitLogik(Action<string,string> myAction, string anrede, string vorname)
        {
            Console.WriteLine("Jetzt kommt die Ausgabe");
            myAction(anrede, vorname);
        }
        public static void Hello(string anrede, string fistname)
        {
           Console.WriteLine(anrede + " " + fistname);
        }
        public static void HelloMitBinde(string anrede, string fistname)
        {
            Console.WriteLine(anrede + "-" + fistname);
        }
        public static void HelloMitStrichpunkt(string anrede, string fistname)
        {
            Console.WriteLine(anrede + ";" + fistname);
        }
        public static void HelloMitSlash(string anrede, string fistname)
        {
            Console.WriteLine(anrede + "//" + fistname);
        }

        public static void HelloFirstname(string firstname)
        {
            Console.WriteLine("Hello " + firstname);
        }
    }
}
