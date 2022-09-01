/*

C#              Beskrivning
-----------------------------------------------------------------------------------

String          Till för text
int             Till för heltal (1, 2, 3 etc.)      32 bit
uint            Till för heltal (1, 2, 3 etc.)      32 bit      börjar med 0
long            Till för heltal (1, 2, 3 etc.)      64 bit
ulong           Till för heltal (1, 2, 3 etc.)      64 bit      börjar med 0
decimal         Till för decimaltal (1.1, 1.2 etc.)
double          Till för decimaltal (1.1, 1.2 etc.)
float           Till för decimaltal (1.1, 1.2 etc.)
object          Till för objekt
array           Statiska listor
list            Dynamiska listor
bool            Sant/Flaskt True/False
char            Till för tecken
dynamic         Kan vara vad som helst
Guid            Skapar ett unikt id (Globally Unique Identifier)
null            ingenting


Deklarera variabler
-----------------------------------------------------------------------------------
Best practice i C# är att deklarera en variabel (som är en lagringsplats för ett värde)
med en datatyp. Men det går att använda var och låta värdet bestämma datatypen.

string firstName = "Hans Emil";           en variable av datatypen string
var firstName = "Hans Emil";              en variable av datatypen ....



String - textbaserade värden
------------------------------------------------------------------------------------

string firstName = "emil1";
string lastName = "Olsson";

string sentence = "Jag är \"bäst\" i hela världen.";
string sentence = "Hans sa "jag är ’bäst’ i hela världen.";

string placeholder = "Jag heter " +  firstName + " " + lastname + ".";
string placeholder = $"Jag heter {firstName} {lastName}.";
string placeholder = string.Format("Jag heter {0}{1}.", firstName, lastName);

string filepath = "C:\\Users\\emil1\\Skrivbord";
string filepath = @"C:\Users\emil1\Skrivbord";
string filepath= @$"C:\Users\{firstName}\Skrivbord";

Console.WriteLine("Lower: " + firstName.ToLower());
Console.WriteLine("Upper: " + firstName.ToUpper()" );
Console.WriteLine("Trim: " + firstName.Trim());
Console.WriteLine("Split: " + firstName.Split(".")[0]);
Console.WriteLine("Replace: " + firstName.Replace("a", "g"));

 */












Console.WriteLine("Write your first name"); 

string firstName = Console.ReadLine();

Console.WriteLine("Write your last name");

string lastName = Console.ReadLine();

Console.WriteLine("Write your title");

string title = Console.ReadLine();

Name(firstName, lastName, title);

static void Name(string firstName, string lastName, string title)
{
Console.WriteLine(firstName + " " + title + " " + lastName);
}