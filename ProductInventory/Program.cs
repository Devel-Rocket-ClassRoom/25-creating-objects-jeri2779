using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 상품 목록 ===");

Product[] product = new Product[]
{
    new Product { Name = "노트북", Price = 1500000, Stock = 5 },
    new Product { Name = "마우스", Price = 35000, Stock = 20 },
    new Product { Name = "키보드", Price = 89000, Stock = 15 }
};

 
foreach (Product item in product)
{
    Console.WriteLine(item);
}
Console.WriteLine("=== 거래 ===");
product[0].Sell(2);
product[1].Sell(5);
product[2].Sell(20);  
product[2].AddStock(10);
Console.WriteLine();
Console.WriteLine("=== 최종 상품 목록 ===");
foreach (Product item in product)
{
    Console.WriteLine(item.ToString());
}


Console.WriteLine("=== 총 재고 가치 ===");
int totalSum = 0;
foreach (Product item in product)
{
    int value = item.GetTotalValue();
    Console.WriteLine($"{item.Name}: {value}원");
    totalSum += value;
}
Console.WriteLine("---");
Console.WriteLine($"전체 재고 총 가치: {totalSum}원");




class Product
{
    public string Name;
    public int Price;
    public int Stock;

    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"{Name} {quantity}개 재고 추가. 현재 재고: {Stock}개");

    }
    public void Sell(int quantity)
    {
        if (Stock < quantity)
        {
            Console.WriteLine($"{Name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {Stock}개)");
            return;
        }
        Stock -= quantity;
        Console.WriteLine($"{Name} {quantity}개 판매 완료. 남은 재고: {Stock}개");
    }

    public int GetTotalValue()
    {
        return Price * Stock;
    }

    public override string ToString()
    {
        return $"[{Name}] {Price}원 (재고: {Stock}개)";
    }

    

}
