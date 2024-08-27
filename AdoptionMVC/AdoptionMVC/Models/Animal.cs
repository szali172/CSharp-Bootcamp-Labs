using System.ComponentModel.DataAnnotations;

namespace AdoptionMVC.Models;

public class Animal
{
    public int ID { get; set; }

    [Required]
    public string Name { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }
    public string ImageName { get; set; }
    public bool IsAdopted {  get; set; }

    [Required]
    public string Breed { get; set; }
    public AnimalType PetType { get; set; }
}
