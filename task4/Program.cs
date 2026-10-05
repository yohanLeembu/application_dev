int[] numbs = {1,3,4,2,5,8,10};
Array.Sort(numbs);
Console.WriteLine($"Sorted: {string.Join(", ",numbs)}");
Array.Reverse(numbs);
Console.WriteLine($"Reversed: {string.Join(", ",numbs)}");

for(int i= 0; i < numbs.Length; i++)
{
    Console.WriteLine(numbs[i]);
}

int index = Array.IndexOf(numbs, 4);
Console.WriteLine(index);

