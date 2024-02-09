namespace RestaurantReservation.API.ViewModels
{
    public class CollectionVM<T>
    {
        public int Count { get; set; }
        public List<T> Items { get; set; } = new List<T>();
    }
}
