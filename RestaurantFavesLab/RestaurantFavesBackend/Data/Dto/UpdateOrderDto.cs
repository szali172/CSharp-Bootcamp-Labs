namespace RestaurantFavesLab.Data.Dto;

public class UpdateOrderDto
{
    public string Description { get; set; }
    public string Restaurant { get; set; }
    public int Rating { get; set; }
    public bool OrderAgain { get; set; }
}
