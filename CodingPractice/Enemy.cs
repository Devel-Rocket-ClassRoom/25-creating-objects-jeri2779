using System;

class Enemy
{
    public string Name;
 
    public int Health;

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP {Health}");
    }
}