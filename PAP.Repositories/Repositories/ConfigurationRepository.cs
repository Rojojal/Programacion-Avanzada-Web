using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PAP.Data;
using PAP.Models.Models;
using PAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Repositories.Repositories
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly PAPDbContext _context;

        public ConfigurationRepository(PAPDbContext context)
        {
            _context = context;
        }

        public async Task<Configuration> GetConfigurationAsync()
        {
            return await _context.Configuration.FirstOrDefaultAsync();
        }

        public async Task UpdateConfigurationAsync(Configuration newConfig)
        {
            var config = await _context.Configuration.FirstOrDefaultAsync();

            config.Font = newConfig.Font;
            config.Color = newConfig.Color;
            config.FontSize = newConfig.FontSize;

            _context.Configuration.Update(config);

            await _context.SaveChangesAsync();
        }
    }
}
