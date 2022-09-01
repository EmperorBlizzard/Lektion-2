/*

C#              Beskrivning
-----------------------------------------------------------------------------------------------------
Standard datatyper i C# som används för att tala om ... 
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
Byte


Deklarera variabler
-----------------------------------------------------------------------------------------------------
Best practice i C# är att deklarera en variabel (som är en lagringsplats för ett värde)
med en datatyp. Men det går att använda var och låta värdet bestämma datatypen.

string firstName = "Hans Emil";           en variable av datatypen string
var firstName = "Hans Emil";              en variable av datatypen ....



String - textbaserade värden
-----------------------------------------------------------------------------------------------------

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




INTEGRALS & FLOATING POINTS
-----------------------------------------------------------------------------------------------------
    1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536

    INTEGRALS           BITS            RANGE(min, max)
    -------------------------------------------------------------------------------------------------
    Detta är bara för heltal, inte decimaltal
    
    byte                8               0                       255
    sbyte               8               -128                    127
    short               16              -32768                  32767
    ushort              16              0                       65535
    int                 32              -2147483648             2147483647
    uint                32              0                       4294967295
    long                64              -9223372036854775808    9223372036854775807
    ulong               64              0                       18446744073709551615
    
    Int16               16              = short
    Int32               32              = int
    Int64               64              = long


    FLOATING POINTS     Bytes       DECIMAL RANGE       SUFFIX          ANVÄNDS FÖR
    -------------------------------------------------------------------------------------------------
    
    float               4           6-9 digits          f eller F       sensorer, machine learning
    double              8           15-16 digits        d eller D       prestandeaoptimering
    decimal             16          28-29 digits        m eller M       finansiella tal
    
    float floatValue = 0.1f + 0.1f + 0.1f;
    double doubleValue = 0.1 + 0.1 + 0.1d;
    decimal decimalValue = 0.1m + 0.1m + 0.1m;
    Console.WriteLine("Float: " + floatValue);
    Console.WriteLine("Double: " + doubleValue);
    Console.WriteLine("Decimal: " + decimalValue);



BOOL (BOOLEAN)      Bits
-----------------------------------------------------------------------------------------------------
bool                0/1     false/true

Guid (Globally Unique Identifier)       
-----------------------------------------------------------------------------------------------------
Guid        16 bytes        Guid.NewGuid();         8428f0al-129e-a5aa-461bfd15da84



DESIGN PATTERN vid namngivning
-----------------------------------------------------------------------------------------------------
ALLWAYS ENGLISH

camelCase           firstName               Javascript, Java, c/c++
Pascal              FirstName               C#, Psacal
snake_case          first_name              Python


Class - Field               private string firstName
Class - Property            public string FirstName { get; set; }
Class - Methods             public voidMethodName() {}

Parameter                   MethodName(String parameterName, int parameterName)
Variable                    string firstName, string _firstName


 */





/*
Console.Write("Write your first name"); 

string firstName = Console.ReadLine();

Console.Write("Write your last name");

string lastName = Console.ReadLine();

Console.Write("Write your title");

string title = Console.ReadLine();

WriteName(firstName, lastName, title);

static void WriteName(string firstName, string lastName, string title)
{
Console.WriteLine(firstName + " " + title + " " + lastName);
}

*/