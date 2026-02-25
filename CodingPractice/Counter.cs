using System;

class Counter
{
    public int count = 0;

    public void Increment()
    {
        count++;
        Console.WriteLine($"현재 카운트: {count}");
    }
    public void Reset()
    {
        count = 0;
        Console.WriteLine("카운트가 초기화되었습니다.");
    }


}



