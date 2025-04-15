using Microsoft.EntityFrameworkCore;
using PAP.Models.Models;
using PAP.Repositories.Interfaces;
using PAP.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Services.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository _repo;

        public ConfigurationService(IConfigurationRepository repo)
        {
            _repo = repo;
        }

        public async Task<Configuration> GetConfigurationAsync()
        {
            return await _repo.GetConfigurationAsync();
        }

        public async Task UpdateConfigurationAsync(Configuration newConfig)
        {
            await _repo.UpdateConfigurationAsync(newConfig);
        }
    }
}

