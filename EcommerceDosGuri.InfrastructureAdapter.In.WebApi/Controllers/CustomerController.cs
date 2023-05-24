using EcommerceDosGuri.Application.UseCase.UseCase.Customers.AddCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.DeleteCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetAllCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.UpdateCustomers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.InfrastructureAdapter.In.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IGetAllCustomersInterector _getAllCustomersInterector;
        private readonly IGetCustomerByIdInterector _getCustomerByIdInterector;
        private readonly IAddCostumerInterector _addCostumerInterector;
        private readonly IUpdateCustomerInterector _updateCustomerInterector;
        private readonly IDeleteCustomerInterector _deleteCustomerInterector;

        public CustomerController(IGetAllCustomersInterector getAllCustomersInterector,
            IGetCustomerByIdInterector getCustomerByIdInterector,
            IAddCostumerInterector addCostumerInterector,
            IUpdateCustomerInterector updateCustomerInterector,
            IDeleteCustomerInterector deleteCustomerInterector)
        {
            _getAllCustomersInterector = getAllCustomersInterector;
            _getCustomerByIdInterector = getCustomerByIdInterector;
            _addCostumerInterector = addCostumerInterector;
            _updateCustomerInterector = updateCustomerInterector;
            _deleteCustomerInterector = deleteCustomerInterector;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            IReadOnlyCollection<GetAllCustomersPortOut> customers = await _getAllCustomersInterector
                .ExecuteAsync();

            return Ok(customers);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] GetCustomerByIdPortIn dataPortIn)
        {
            GetCustomerByIdPortOut customer = await _getCustomerByIdInterector
                .ExecuteAsync(dataPortIn);

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerAsync(AddCustomerPortIn dataPortIn)
        {
            AddCustomerPortOut response = await _addCostumerInterector.ExecuteAsync(dataPortIn);

            return Created($"api/[controller]/{response.Id}", response.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerAsync(UpdateCustomerPortIn dataPortIn)
        {
            await _updateCustomerInterector.ExecuteAsync(dataPortIn);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerAsync(DeleteCustomerPortIn dataPortIn)
        {
            await _deleteCustomerInterector.ExecuteAsync(dataPortIn);

            return NoContent();
        }
    }
}
