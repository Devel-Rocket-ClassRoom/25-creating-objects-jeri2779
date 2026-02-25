class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[아이템]{Name} - {Price}";
    }
}