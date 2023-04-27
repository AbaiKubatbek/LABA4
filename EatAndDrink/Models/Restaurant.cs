namespace EatAndDrink.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Order> Orders { get; set; }
    }
}
