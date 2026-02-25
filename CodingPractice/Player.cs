class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"[{Level}레벨] {Name} (HP: {Health})";
    }
}