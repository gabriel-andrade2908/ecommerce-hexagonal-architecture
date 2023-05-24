using Newtonsoft.Json;
using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById
{
    public class GetCustomerByIdPortIn
    {
        [JsonProperty("id")]
        public Guid id { get; set; }
    }
}
