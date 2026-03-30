//Írj egy tetszőleges témájú programot, ami megfelel az alábbi technológiai követelményeknek a tanultak alapján:
//Nem kihagyható elemek:
//Legyen benne kivételkezelés (try-catch)
//Legalább a képenyőre írjon ki hibaüzeneteket

//Kötelezelő elemek - Ezek közül egy kihagyható vagy cserélhető, ha Unit és/vagy Integration tesztek tartoznak a projekthez:
//adat olvasása fájlból szerializáció segítségével (pl.: Adat betöltés és / vagy mentés JSON/XML fájlból/fájlba)
//legyen benne saját immutable type (pl.: record class)
//  e.g : public record BeszerzesiAdat(string Honnan, DateTime BeszerzesDatuma, decimal Ar);
//  e.g : public record HalFaj(string MagyarNev, string TudomanyosNev, string Elohely, double AtlagosElettartamEv);
//legyen benne LINQ segítségével: szűrés(where), csoportosítás(group by), rendezés(order by), agregáció(Pl.: Min(), Max(), First(), FirstOrDefault, Average(), stb...) közül legalább kettő
//legyen benne generikus kollekció (pl.: List, Stack, stb...)

//Értékelés: Az értékelés utolsó órán védéssel fog zárulni.
//Két ember dolgozhat egy alkalmazáson, de akkor a Unit tesztek megléte kötelező és nem opcionális!
//Kódot fogom nézni, nem a program működését főként, de ez nem azt jelenti, hogy a kódnak nem kell fordulnia! (Unit teszt ha van, akkor az bukhat, de indokot várok ebben az esetben, hogy miért bukik a teszt.)
//A karakterek ingyen vannak. Legyen normálisan elnevezve minden. Nem akarok látni asd, a, b, c meg semmit mondó metódus, tulajdonság és változó neveket.
//Folyamatos munkát várok éppen ezért majd GIT repository-ba kell tenni munkát és nem egy giga maratonban kommitolást szeretnék látni, mert akkor másolást, de minimum sunyulást tételezek fel => nehezebb lesz védeni.

using FishLibrary.Data;
using FishLibrary.Core;

internal class Program
{
    private static int Main(string[] args)
    {
        FishSerializer serializer = new FishSerializer();
        List<Fish> fishCollection = serializer.LoadFishes();

        Console.WriteLine("Welcome to the FishLibrary!");
        Console.WriteLine("Select an option:");
        Console.WriteLine("A) Look up fish");
        Console.WriteLine("B) Add fish");
        Console.WriteLine("C) Remove fish");
        Console.WriteLine("D) List all fish");
        Console.WriteLine("X) Exit");
        Console.Write("> ");
        string option = Console.ReadLine() ?? string.Empty;

        //before all of this, we will need to load up the json, and create a collection of the fishes 
        switch (option)
        {
            case "A":
               //Look up fish, ask for detail (maybe like based on name / age / color)
                break;
            case "B":
               // Add fish, best to ask for data line by line: name, age, color
               // -> create fish object, add to collection, serialize to json
                break;
            case "C":
                // Remove based on name , yes we will not let two fish have the same name 
                break;
            case "D":
                // List all fishes
                break;
            default:
                Console.WriteLine("Invalid option. Please select A, B, C, D, or X.");
                break;

        }

        return 0;
    }
}