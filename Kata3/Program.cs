using System;

namespace Kata3
{
    class Program
    {
        static void Main(string[] args)
        {
            IVariousDates dates = new VariousDates();

            Console.WriteLine($"Sorted Dates {dates.Count()} dates");
            dates.Sort();
            Console.WriteLine(dates);

            for (int month = 0; month < 12; month++)
            {
                Console.WriteLine($"month nr {month} caontains {dates.Count(month)} dates.");
            }
        }
    }
}
/*Kata2 en variant av Kata1

Vi ska enkapsulara en lista<DateTime> i en klass VariousDates och göra några enklare 
metoder på klassen och listan i klassen.

Uppgifter:
1. Deklarara ett Interface IVariousDates som definierar
	- Metod, Count, som räknar antalet skapade datum i en viss månad
	- Metod, Count, som returnerar totala antalet datum skapade
	- Metod, Sort, som sorterar datum en lista

2. Implementera IVariousDates i en class, VariousDates 
3. Här ska ni kunna kompilera (inte köra) programmet utan röda wigglar

4. I VariousDates 
	- Skapa en lista av DateTime
	- Skapa en constructor som skapar ett antal element i listan med random datum
	- Override ToString() för att skriva Datum 5 per rad
5. I Program skapa en instans av VariousDates och skriv ut den
6. Implementera Count och Sort
7. Skriv några kodrader i Program som testar Count och Sort

Träna, Träna, Träna. Ovan moment 1-8 ska jobbas in i långtidsminne och muskelminne
Lycka till!


Ni som vill ta katan till ny nivå, gör nedan:

8. Gör listan till en Lista av struct som innehåller DateTime och coloredSpots
9. lägg till en class indexer till interface
10. Implementera indexern i VariousDates 

11. Sort() ska sortera listan först efter ColoredSpots, sedan efter DateTime*/