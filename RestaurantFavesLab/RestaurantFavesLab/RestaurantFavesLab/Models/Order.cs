namespace RestaurantFavesLab.Models;

public class Order
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Restaurant { get; set; } = string.Empty;
    public int Rating { get; set; } = 0;
    public bool OrderAgain { get; set; }
}
