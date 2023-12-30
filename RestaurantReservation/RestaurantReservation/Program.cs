using RestaurantReservation.Db;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories;
using RestaurantReservation.Db.Services;
using RestaurantReservation.Db.Mapper;
using AutoMapper;
using RestaurantReservation.Db.Repositories.IRepositories;
using FluentResults;
using RestaurantReservation.Db.Enums;

RestaurantReservationDbContext _Context = new RestaurantReservationDbContext();
var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
IMapper mapper = new Mapper(config);


var customerRepository = new CustomerRepository(_Context);
var customerService = new CustomerService(customerRepository, mapper);

var employeeRepository = new EmployeeRepository(_Context);
var employeeService = new EmployeeService(employeeRepository, mapper);

var reservationRepository = new ReservationRepository(_Context);
var reservationService = new ReservationService(reservationRepository, mapper);

var orderRepository = new OrderRepository(_Context);
var orderService = new OrderService(orderRepository, mapper);

//await ListManagersAsync(employeeService);
//await GetReservationsByCustomerAsync(reservationService, 4);
//await ListOrdersAndMenuItems(orderService, 9);
//await ListOrderedMenuItems(orderService, 9);
//await CalculateAverageOrderAmount(orderService, 4);
await FindCustomersByPartySize(customerService, PartySize.mediam);



async Task CalculateAverageOrderAmount(OrderService orderService, int employeeId)
{
    (decimal avgOrderAmount, Result result) = await orderService.CalculateAverageOrderAmount(employeeId);

    if (result.IsSuccess)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Average Order Amount: {avgOrderAmount}");
    }
    else
    {
        result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
    }
}
async Task ListOrderedMenuItems(OrderService service, int reservationId)
{
    (var orderedMenuItems, var result) = await service.ListOrderedMenuItems(reservationId);
    if (result.IsSuccess)
    {
        Console.WriteLine("------------------------------");
        foreach (var menuItem in orderedMenuItems)
        {
            Console.WriteLine(menuItem);
        }
        Console.WriteLine("------------------------------");
    }
    else
    {
        result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
    }
}

async Task FindCustomersByPartySize(CustomerService service, PartySize partySize)
{
    (var customers, var result) = await service.FindCustomersByPartySize(partySize);
    if (result.IsSuccess)
    {
        Console.WriteLine("------------------------------");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine("------------------------------");
    }
    else
    {
        result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
    }
}

async Task ListOrdersAndMenuItems(OrderService service, int reservationId)
{
    (var ordersWithMenuItemsDTOs, var result) = await service.ListOrdersAndMenuItems(reservationId);
    if (result.IsSuccess)
    {
        Console.WriteLine("------------------------------");
        foreach (var orderWithMenuItemsDTO in ordersWithMenuItemsDTOs)
        {
            Console.WriteLine(orderWithMenuItemsDTO);
        }
        Console.WriteLine("------------------------------");
    }
    else
    {
        result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
    }
}

async Task GetReservationsByCustomerAsync(ReservationService service, int customerId)
{
    (var data, var result) = await service.GetReservationsByCustomerAsync(customerId);
    if (result.IsSuccess)
    {
        Console.WriteLine("------------------------------");
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------");
    }
    else
    {
        result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
    }
}

async Task ListManagersAsync(EmployeeService service)
{
    (var data, var result) = await service.ListManagersAsync();
    if (result.IsSuccess)
    {
        Console.WriteLine("------------------------------");
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------");
    }
    else
    {
        result.Errors.ForEach(e => Console.WriteLine($"Failed: {e.Message}"));
    }
}

/*

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
};*/

/*var result = await customerService.CreateAsync(customerDTO);
*/