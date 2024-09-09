namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
    public bool HavePeperoni { get; set; }
    public bool HaveCheese { get; set; }
    public bool HaveMushroom { get; set; }
    public bool HaveTomato { get; set; }
    public bool HaveOnion { get; set; }
    public bool HaveGarlic { get; set; }
    public bool HaveOlives { get; set; }
    public bool HavePineapple { get; set; }
    public bool HaveHam { get; set; }
    public bool HaveBacon { get; set; }
    public bool HaveEgg { get; set; }
}