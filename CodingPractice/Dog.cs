using System;

class Dog
{
    public string Name;
    public int Age;

    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
        Console.WriteLine($"이름: {Name}, 나이: {Age}");
    }
}


