namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card 
{
    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }

    public override string ToString()
    {
        return $"{Color} {Number}";
    }

}