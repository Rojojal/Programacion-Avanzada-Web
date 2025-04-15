using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Models.Models
{
    public partial class Configuration
    {
        public int Id { get; set; }
        public string Font { get; set; }
        public string Color { get; set; }
        public int FontSize { get; set; }
    }
}
