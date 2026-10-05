byte myByte = 100;
short myShort = 1000;
int myInt = 100000;
long myLong = 1000000000L;

float myFloat = 10.5f;
double myDouble = 20.5;
decimal myDecimal = 30.5m;

char myChar = 'A';
string pk = "3.14";
bool myBool = true;

string Attack = myInt;
double Pi = pk;

Console.WriteLine($"Byte: {myByte.GetType().Name} = {myByte}");
Console.WriteLine($"Short: {myShort.GetType().Name} = {myShort}");
Console.WriteLine($"Int: {myInt.GetType().Name} = {myInt}");
Console.WriteLine($"Long: {myLong.GetType().Name} = {myLong}");
Console.WriteLine($"Float: {myFloat.GetType().Name} = {myFloat}");
Console.WriteLine($"Double: {myDouble.GetType().Name} = {myDouble}");
Console.WriteLine($"Decimal: {myDecimal.GetType().Name} = {myDecimal}");
Console.WriteLine($"Char: {myChar.GetType().Name} = {myChar}");
Console.WriteLine($"Bool: {myBool.GetType().Name} = {myBool}");