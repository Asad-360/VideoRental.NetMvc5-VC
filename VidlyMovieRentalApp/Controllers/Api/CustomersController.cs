using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using VidlyMovieRentalApp.Dtos;
using VidlyMovieRentalApp.Models;
using System.Data.Entity;
namespace VidlyMovieRentalApp.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private  ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customers = _context.Customers
                .Include(c => c.MembershipType)
                .ToList().Select(Mapper.Map<Customer, CustomerDto>);
            return Ok(customers);
        }

        // GET /api/customers/1
        [HttpGet]
        public IHttpActionResult GetCustomers(int id)
        {
            var customers = _context.Customers.SingleOrDefault(m => m.Id == id);

            if (customers == null)
            {
                return NotFound();
            }

           return Ok(Mapper.Map<Customer, CustomerDto>(customers));
        }

        //POST /api/customer
        // Correct
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

           var customers =  Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customers);
            _context.SaveChanges();
            customerDto.Id = customers.Id;
            return Created(new Uri(Request.RequestUri +"/" + customers.Id), customerDto);
        }


        //PUT /api/customer/id 
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto )
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);
            _context.SaveChanges();
        }


        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}