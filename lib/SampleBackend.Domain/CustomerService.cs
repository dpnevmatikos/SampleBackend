using Codehub.Create.Core;

using Microsoft.EntityFrameworkCore;

using SampleBackend.Data;
using SampleBackend.Domain.Options;
using SampleBackend.Model;

namespace SampleBackend.Domain
{
    public class CustomerService : ICustomerService
    {
        private readonly SampleBackendDbContext _dbContext;

        public CustomerService(SampleBackendDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _dbContext
                .Set<Customer>()
                .ToListAsync();
        }

        public async Task<ApiResult<Customer>> RegisterAsync(
            RegisterCustomerOptions options)
        {
            if (options == null)
            {
                return ApiResult<Customer>.CreateFailed(
                    ResultCode.BadRequest, "Null options");
            }

            if (string.IsNullOrWhiteSpace(options.Name))
            {
                return ApiResult<Customer>.CreateFailed(
                    ResultCode.BadRequest, "Null customer name");
            }

            var customer = new Customer()
            {
                Name = options.Name,
                Surname = options.Surname,
                VatNumber = options.VatNumber,
                RegistrationDate = DateTimeOffset.Now
            };

            _dbContext.Add(customer);

            try
            {
                await _dbContext.SaveChangesAsync();
            } catch (Exception ex)
            {
                return ApiResult<Customer>.CreateFailed(
                    ResultCode.InternalServerError, $"Could not update database: {ex.Message}");
            }

            return ApiResult<Customer>.CreateSuccessful(
                customer);
        }
    }
}