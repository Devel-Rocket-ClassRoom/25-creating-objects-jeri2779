using System;

class GameManager
{
    public static int TotalPlayers = 0;

    public static void ShowStatus()
    {
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }
    public string PlayerName;

    
    public void Greet()
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }

}


