using RestaurantReservation.Db;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories;
using RestaurantReservation.Db.Services;
using RestaurantReservation.Db.Mapper;
using AutoMapper;

RestaurantReservationDbContext _Context = new RestaurantReservationDbContext();
var customerDTO = new CustomerDTO
{
    FirstName = "Tasbeeh",
    LastName = "Takrori",
    Email = "tabeh.takrore2@gmail.com",
    PhoneNumber = "0599998888"
};
Console.WriteLine("Hello");
var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
IMapper mapper = new Mapper(config);
IEntityRepository<Customer> customerRepository = new EntityRepository<Customer>(_Context);
var customerService = new EntityService<Customer, CustomerDTO>(customerRepository, mapper);
var result = await customerService.CreateAsync(customerDTO);
if (result.IsSuccess)
{
    Console.WriteLine("Success!!");
}
else
{
    result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
}