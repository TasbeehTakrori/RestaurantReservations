namespace RestaurantReservation.API.ViewModels
{
    /// <summary>
    /// View model for representing a collection of items.
    /// </summary>
    /// <typeparam name="T">The type of items in the collection.</typeparam>
    public class CollectionVM<T>
    {
        /// <summary>
        /// The total count of items in the collection.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The list of items in the collection.
        /// </summary>
        public List<T> Items { get; set; } = new List<T>();
    }
}
