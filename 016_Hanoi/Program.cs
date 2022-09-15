Hanoi(3, 'a', 'b', 'c');

void Hanoi(int floor, char from, char visit, char to)
{
    if (floor == 1)
        Console.WriteLine(from + "->" + to);
    else
    {
        Hanoi(floor - 1, from, to, visit);
        Console.WriteLine(from+"->"+visit);
        Hanoi(floor - 1, visit, from, to);
    }
}