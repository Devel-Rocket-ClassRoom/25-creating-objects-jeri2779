using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Xml.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Console.WriteLine("## 과제 1: 간단한 클래스와 개체");

Dog myDog = new Dog();
myDog.Name = "초코";
myDog.Age = 3;
myDog.Bark();

Console.WriteLine("## 과제 2: var 키워드로 개체 생성");
Monster m1 = new Monster();
Console.WriteLine(m1);
var m2 = new Monster();
Console.WriteLine(m2);

Console.WriteLine("## 과제 3: 인스턴스 메서드");
Calculator calculator = new Calculator();
calculator.Add(3, 5);
calculator.Multiply(4, 6);

Console.WriteLine("## 과제 4: 인스턴스 메서드와 필드");

Counter counter = new Counter();
counter.Increment();  // 1
counter.Increment();  // 2
counter.Increment();  // 3
counter.Reset();      // 0

Console.WriteLine("## 과제 5: 정적 멤버와 인스턴스 멤버");

GameManager.TotalPlayers = 10;
GameManager.ShowStatus();
 
GameManager manager = new GameManager();
manager.PlayerName = "홍길동";
manager.Greet();


Console.WriteLine("## 과제 6: 여러 클래스 함께 사용");
Greeting.SayHello();
Farewell.Wave();

// 인스턴스 멤버 호출
Greeting greeting = new Greeting();
greeting.SayGoodbye();

Farewell farewell = new Farewell();
farewell.Bow();

Console.WriteLine("## 과제 7: ToString() 기본 동작");
Item0 item = new Item0();
item.Name = "포션";
item.Price = 100;
Console.WriteLine(item);

Console.WriteLine("## 과제 8: ToString() 오버라이드");
Item item2 = new Item();
item2.Name = "포션";
item2.Price = 100;
Console.WriteLine(item2);
 
Console.WriteLine();

Console.WriteLine("## 과제 9: ToString() 활용");
Player player1 = new Player();
player1.Name = "전사";
player1.Level = 10;
player1.Health = 200;

Player player2 = new Player();
player2.Name = "마법사";
player2.Level = 8;
player2.Health = 120;

Console.WriteLine(player1);
Console.WriteLine(player2);
Console.WriteLine();

Console.WriteLine("## 과제 10: 클래스 배열");
Enemy[] enemies = new Enemy[3];

// 각 요소에 개체 생성
enemies[0] = new Enemy();
enemies[0].Name = "고블린";
enemies[0].Health = 50;

enemies[1] = new Enemy();
enemies[1].Name = "오크";
enemies[1].Health = 100;

enemies[2] = new Enemy();
enemies[2].Name = "드래곤";
enemies[2].Health = 500;

for(int  i = 0; i < enemies.Length; i++)
{
    enemies[i].ShowInfo();
}


Console.WriteLine("## 과제 11: foreach로 클래스 배열 순회");

Item[] inventory = new Item[3];
inventory[0] = new Item { Name = "검", Price = 500 };
inventory[1] = new Item { Name = "방패", Price = 300 };
inventory[2] = new Item { Name = "포션", Price = 50 };

foreach(Item item1 in inventory)
{
    Console.WriteLine(item1);
}

Console.WriteLine("## 과제 12: 개체 이니셜라이저");
Character chara = new Character();
chara.Name = "홍길동";
chara.Level = 1;
chara.Job = "전사";

Character chara2 = new Character
{
    Name = "이순신",
    Level = 5,
    Job = "궁수"
};
Console.WriteLine($"{chara.Name} - {chara.Job} Lv.{chara.Level}");
Console.WriteLine($"{chara2.Name} - {chara2.Job} Lv.{chara2.Level}");

Console.WriteLine("## 과제 13: 배열에서 개체 이니셜라이저 활용");
Student[] students = new Student[3]
{
    new Student { Name = "김철수", Score = 85 },
    new Student { Name = "이영희", Score = 92 },
    new Student { Name = "박민수", Score = 78 }
};

foreach (Student student in students)
{
    Console.WriteLine(student);
}
