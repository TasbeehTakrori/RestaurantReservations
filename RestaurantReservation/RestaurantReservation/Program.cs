using RestaurantReservation.Db;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories;
using RestaurantReservation.Db.Services;
using RestaurantReservation.Db.Mapper;
using AutoMapper;

RestaurantReservationDbContext _Context = new RestaurantReservationDbContext();
var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
IMapper mapper = new Mapper(config);
/*var repository = new EntityRepository<Customer>(_Context);
var service = new EntityService<Customer, CustomerDTO, IEntityRepository<Customer>>(repository, mapper);
*/
/*var result = await customerService.CreateAsync(customerDTO);*/

var repository = new EmployeeRepository(_Context);

EmployeeService service = new EmployeeService(repository, mapper);


(var data, var result) = await service.ListManagersAsync();
if (result.IsSuccess)
{
    Console.WriteLine("Success!!");
    foreach (var item in data)
    {
        Console.WriteLine(item);
    }
}
else
{
    result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
}


var customerDTO = new CustomerDTO
{
    FirstName = "Tasbeeh",
    LastName = "Takrori",
    Email = "tabeh.takrore2@gmail.com",
    PhoneNumber = "0599998888"
};