using System;

namespace Simple_Objekter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Vi bruger classes til at definere objekt-typer. 
            //Main funktionen er indeholdt i en klasse der hedder "Program".
            //Hvis du scroller ned kan du se definitionen af an klasse der hedder Person. Den kommer vi til at arbejde med i dette opgave sæt.


            //Man kan oprette en udgave af en class således:
            Person me = new Person();

            //Og man kan derefter sætte værdierne, ved at bruge "dot-notation".
            me.name = "Mads";
            me.age = 30;

            //TODO Opgave 1: Ændrer name og age i objektet "person" til at passe på dig i stedet.

            //TODO Opgave 2: Tilføj et felt i klassen Person der skal holde en persons hjemby.

            //TODO Opgave 3: Lav en funktion der kan tage imod en et objekt af typen Person og returnere en forklaring af objektet.
            //Eksempel: "Mads er 30 år og bor i Nørresundby"

            
            //TODO Opgave 4: Definer en klasse som hedder Job. Den skal som minimum have to felter. "Title" og "Salery".
            //NOTE husk at definere klassen i det rigtige scope.

            //TODO Opgave 5: Lav 3 variabler af typen Job herunder. De skal alle 3 have forskellige jobs. Du vælger selv hvilke værdier der skal være heri.

            //TODO Opgave 6: Lav et array med plads til 10 objekter af typen Job. Fyld dette array med minimum 10 forskellige eksempler på jobs.

            //TODO Opgave 7: Lav en funktion som kan tage imod et array af jobs, og retuner det job som har det højeste salery. Det er nødvendigt at lave et loop for at løse denne opgave.
        }
    }

    //Den 'Person' klasse vi arbejder med i dette opgavesæt. Læg mærke til at classes bør defineres i "namespace" scope.
    class Person
    {
        public string name;
        public int age;
    }
}
