using System;

class Calculator
{
    public void Add(int x, int y)
    {
        int addsum = x + y;
        Console.WriteLine($"합계: {addsum}");

    }
    public void Multiply(int x, int y)
    {
        int mulsum = x * y;
        Console.WriteLine($"곱: {mulsum}");
    }
}



