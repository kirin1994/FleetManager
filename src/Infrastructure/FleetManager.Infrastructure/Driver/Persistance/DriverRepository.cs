using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.Infrastructure.Driver.Persistance
{
    public class DriverRepository : IDriverRepository
    {
        private DriverContext _driverContext;

        public DriverRepository(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }

        public async Task<List<Core.Models.Driver>> GetAllDriversAsync()
        {
            return await _driverContext.Drivers.ToListAsync();
        }

        public async Task<Core.Models.Driver> GetDriverByIdAsync(Guid id)
        {
            return await _driverContext.Drivers.FirstOrDefaultAsync(d => d.Id == id);
        }
    }
}
