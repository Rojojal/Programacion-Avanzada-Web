using PAP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Services.Interfaces
{
    public interface IConfigurationService
    {
        Task<Configuration> GetConfigurationAsync();
        Task UpdateConfigurationAsync(Configuration newConfig);
    }
}
