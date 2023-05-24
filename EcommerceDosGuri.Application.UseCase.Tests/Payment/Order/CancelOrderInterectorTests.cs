using Xunit;

namespace EcommerceDosGuri.Application.UseCase.Tests.Catalog.Product
{
    public class CancelOrderInterectorTests
    {
        [Fact]
        public async Task Execute_WhenAllDataAreCorrect_ReturnsOk()
        {

        }

        [Fact]
        public async Task Execute_WhenOrderIsNotInDataBase_ReturnsNotFound()
        {

        }

        [Fact]
        public async Task Execute_WhenOrderStatusIsNotPending_ReturnsBadRequest()
        {

        }
    }
}
