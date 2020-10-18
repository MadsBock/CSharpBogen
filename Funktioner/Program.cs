using System;

namespace Funktioner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funktioner kan bruges til at lave små programmer med input og output inde i vores program.
            //Man kan ærklære en funktion således
            void DoSomething()
            {
                Console.WriteLine("Im Doing Something");
            }
            //Når man ærklærer en funktion, definerer man noget funktionalitet som man så kan bruge på et senere tidspunkt.
            //Man kan kalde funktionen således

            DoSomething(); //NOTE paranteserne indikere at man gerne vil kalde funktionen. Med andre ord, køre den.

            //TODO Opgave 1: Kør programmet og test at der bliver skrevet "Im Doing Something" i konsollen.
            //TODO Opgave 2: Kald DoSomething() metoden 5 gange.


            //Funktioner kan meget mere end at gemme kode. Man kan give sin funktion input, ved at definere nogle parametre.
            void SayHelloTo(string name)
            {
                Console.WriteLine("Hello " + name);
            }

            //Og så kalde den med en passende string værdi
            //SayHelloTo("Mads");

            //TODO Opgave 3: Kald SayHelloTo 3 gange. Den skal sige hej til dig selv og dine side kammerater.


            //Man kan give funktioner output ved at lave return statements. Det første man skal gøre er at give sin funktion en retur-type.
            //Følgende funktion har to ints som input parametre, og int som returtypen.
            int AddTwoNumbers(int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            }

            //TODO Opgave 4: Kald AddTwoNumbers, og gem resultatet af funktionen i en variabel. 

            //TODO Opgave 5: Lav AddTwoNumbers om så den bruger double i stedet for int.

            //TODO Opgave 6: Lav en funktion der hedder SubtractTwoNumbers, som kan trække to tal fra hinanden, og returnere værdien.

            //TODO Opgave 7: Lav en funktion der hedder MultiplyTwoNumbers, som kan gange to tal med hinanden, og returnere værdien.

            //TODO Opgave 8: Lav en funktion der hedder DivideTwoNumbers, som kan dividere to tal med hinanden, og returnere værdien.
            
            //TODO Opgave 9: Lav en funktion der tager imod en integer kaldet i, og en string kaldet tekst. 
            //Funktionen skal skrive inholdet af tekst ud i konsollen et antal gange der er ligmed tallet i.

            //TODO Opgave 10: Lav en funktion der tager imod et array af tal, og returnere summen af tallene i dette array. Det er nødvendigt at lave et loop for at løse denne opgave.
        }
    }
}
