public class Book
{

    public int Id { get; set; }
    public string Title { get; set; } 
    public string Author  { get; set; } 
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Title} ({Price})";
    }
}

