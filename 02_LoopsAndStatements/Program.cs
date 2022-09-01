/*
IF STATEMENT
-----------------------------------------------------------------------------------------------------
==          lika med
!=          inte lika med
<           mindre än
<=          mindre eller lika med
>           större än
>=          större eller lika med
!           om det inte är det här
&&          och 
||          eller           (alt gr + <)


if (true) {}
if (true) {} else {}
if (treu) {} else if (true) {} else {}      MAX
if (treu) {} else if (true) {} else if (true) {} else if (true) {} else {}
(true) ? do_this : do_this

SWITCH
-----------------------------------------------------------------------------------------------------
Alternativ till en if-sats

Switch(value)
{
    case compareValue
        //Do This
        break;

    case compareValue
        //Do This
        break;

    case compareValue
        //Do This
        break;

    default:
        Console.WriteLine("Värdet är något annat");
        break;
}

LOOP
-----------------------------------------------------------------------------------------------------
for             gör något ett givet antal gånger
forwach         gör något för varje värde/objeckt i en lista/array
while           om ett tillstånd är sant gör något tills det inte är sant
do-while        gör något minst en gång och gör det sedan igen tills tillståndet inte är sant


    FOR-LOOP
    -------------------------------------------------------------------------------------------------

    for(int i = 0; i<10 ; i++)
    {
        Consol.WriteLine("loop nr: " + i);
    }

    FOREACH-LOOP
    -------------------------------------------------------------------------------------------------
    
    string[] balls = new string[] {"fotboll", "basketboll", "baseball" };
    
    foreach (var ball in balls)
    {
        Consol.WriteLine(ball);
    }

    WHILE
    -------------------------------------------------------------------------------------------------
    var index = 0;

    while(index < 1000)
    {
        Console.WriteLine("Index är " + index);
        index++;
    }
    
    DO-WHILE
    -------------------------------------------------------------------------------------------------
    var index = 0;
    do
    {
        Console.WriteLine("Index är " + index);
        index++;
    }
    while(index < 1000)
    
    */