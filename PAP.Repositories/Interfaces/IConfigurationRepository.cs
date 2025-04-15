using System;
using Microsoft.Extensions.Configuration;
using PAP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Repositories.Interfaces
{
    public interface IConfigurationRepository
    {
        Task<Configuration> GetConfigurationAsync();

        Task UpdateConfigurationAsync(Configuration newConfig);
    }
}