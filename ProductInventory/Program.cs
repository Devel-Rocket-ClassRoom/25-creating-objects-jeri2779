using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 상품 목록 ===");
Product[] product = new Product[4];
product[0] = new Product();
product[0].Stock = 15; 
product[0].Name = "노트북";
product[0].Price = 1500000;

product[1] = new Product();
product[1].Stock = 20;
product[1].Name = "마우스";
product[1].Price = 35000;

product[2] = new Product();
product[2].Stock = 15;
product[2].Name = "키보드";
product[2].Price = 89000;

//Product stock = new Product
//{
//    Name = "노트북",
//    Price = 1500000,
//    Stock = 5
//};

for (int i = 0; i < product.Length-1; i++)
{
    product[i].ShowInfo();
}

class Product
{
    public string Name;
    public int Price;
    public int Stock;

    public void AddStock(int quantity)
    {
        Name = quantity.ToString();
        Price = quantity;
        Stock++;

    }
    public void Sell(int quantity)
    {

    }

    public void GetTotalValue()
    {
        Price = 0;
    }

    public override string ToString()
    {
        return $"[{Name}] {Price}원 (재고: {Stock}개)";
    }

    public void ShowInfo()//테스트용
    {
        Console.WriteLine($"[{Name}] {Price}원 (재고: {Stock}개)");
    }

}
