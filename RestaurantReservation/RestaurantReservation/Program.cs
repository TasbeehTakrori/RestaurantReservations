using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

RestaurantReservationDbContext _Context = new RestaurantReservationDbContext();
Customer customer = new Customer { 
    FirstName = "Tasbeeh",
    LastName = "Takrori",
    Email = "tabeh.takrore@gmail.com",
    PhoneNumber = "0599998888"
};
Console.WriteLine("Hello");

await createCustomer(customer);

Console.ReadKey();

async Task createCustomer(Customer customer)
{
    _Context.Add(customer);
    await _Context.SaveChangesAsync();
}
async Task DeleteCustomer(Customer customer)
{
    _Context.Remove(customer);
    await _Context.SaveChangesAsync();
}
async Task UpdateCustomer(Customer customer)
{
    _Context.Update(customer);
    await _Context.SaveChangesAsync();
}