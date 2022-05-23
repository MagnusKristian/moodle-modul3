using System;
using System.IO;

namespace inputOutput_ordgåter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var path = @"C:\Users\Magnus GetAcademy\Documents\GitHub\moodle-modul3\inputOutput-ordgåter\ordliste.txt";
            var text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
    }
}






/*
 * Vi skal lage et program som bruker en ordliste til å lage en spesiell type ordgåter. Greia er å finne et ord som slutter på det samme som et annet begynner på, for eksempel kremost og ostekake. Gåten blir da krem_ og _ekake, og så skal man sette inn det samme sist i første ord som først i siste ord og få to meningsfulle ord. 

1. Last ned ordliste fra løsningsforslaget: trykk download på denne siden: github.com/GetAcademy/WordPuzzles/blob/master/Ordg%C3%A5ter/ordliste.txt

2. Lag et program som leser inn alle linjene inn i en array og så går gjennom denne, splitter opp på tabulatortegnet ('\t') og printer så ut selve oppslagsordet. Ikke skriv ut ordet hvis det er det samme som som du skrev ut sist. 

3. Lag en egen metode som gjør det samme som i forrige punkt, men i stedet for å skrive ut, returnere den en ny array med bare selve ordene fra ordlista. Bruk en var list = new List<string>(); og legg til nye tekster i denne vha. list.Add(s);. Til slutt returnerer du lista gjort om til en array vha. return list.ToArray();

4. Ta bare med ord med lengde på 7, 8, 9 eller 10. Og ikke ta med ord som inneholder bindestrek. 

5. Velg et tilfeldig ord fra lista. Se om det finnes et annet ord som begynner på de 3 samme bokstavene som det tilfeldige ordet slutter på. Hvis ikke, prøv samme med 4 og 5. Hvis du finner en match, skriv ut begge ordene. 

6. Endre programmet slik at det finner 200 slike ordgåter. 

7. Still som krav at også bokstavene som er felles er et ord som står oppført i ordlista. 
*/