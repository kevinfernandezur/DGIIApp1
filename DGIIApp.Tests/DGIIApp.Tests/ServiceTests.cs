using DGIIApp.Models;
using Moq;
using Microsoft.Extensions.Logging;
using DGIIApp.Services;
using DGIIApp.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;
using System.Threading.Tasks;

namespace DGIIApp.Tests
{
    public class ContribuyenteServiceTests
    {
        private async Task<AppDbContext> GetDbContextAsync()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: System.Guid.NewGuid().ToString())
                .Options;

            var context = new AppDbContext(options);

            context.Contribuyentes.AddRange(
                new Contribuyente { RncCedula = "10000000001", Nombre = "Test Uno", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                new Contribuyente { RncCedula = "10000000002", Nombre = "Test Dos", Tipo = "PERSONA JURIDICA", Estatus = "INACTIVO" }
            );

            await context.SaveChangesAsync();
            return context;
        }

        [Fact]
        public async Task GetAllAsync_ReturnsAllContribuyentes()
        {
            var context = await GetDbContextAsync();
            var loggerMock = new Mock<ILogger<ContribuyenteService>>();
            var service = new ContribuyenteService(context, loggerMock.Object);

            var result = await service.GetAllAsync();

            Assert.Equal(2, result.Count);
        }
    }

    public class ComprobanteServiceTests
    {
        private async Task<AppDbContext> GetDbContextAsync()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: System.Guid.NewGuid().ToString())
                .Options;

            var context = new AppDbContext(options);

            context.Comprobantes.AddRange(
                new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001", Monto = 1000m, Itbis18 = 180m },
                new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000002", Monto = 500m, Itbis18 = 90m },
                new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000003", Monto = 200m, Itbis18 = 36m }
            );

            await context.SaveChangesAsync();
            return context;
        }

        [Fact]
        public async Task GetAllAsync_ReturnsAllComprobantes()
        {
            var context = await GetDbContextAsync();
            var loggerMock = new Mock<ILogger<ComprobanteService>>();
            var service = new ComprobanteService(context, loggerMock.Object);

            var result = await service.GetAllAsync();

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public async Task GetTotalItbisByRncAsync_ReturnsCorrectSum()
        {
            var context = await GetDbContextAsync();
            var loggerMock = new Mock<ILogger<ComprobanteService>>();
            var service = new ComprobanteService(context, loggerMock.Object);

            var total = await service.GetTotalItbisByRncAsync("10000000001");

            Assert.Equal(270m, total);
        }
    }
}
