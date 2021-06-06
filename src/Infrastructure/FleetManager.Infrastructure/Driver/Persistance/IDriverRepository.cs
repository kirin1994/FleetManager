using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FleetManager.Infrastructure.Driver.Persistance
{
    public interface IDriverRepository
    {
        public Task<Core.Models.Driver> GetDriverByIdAsync(Guid id);
        public Task<List<Core.Models.Driver>> GetAllDriversAsync();
    }
}
