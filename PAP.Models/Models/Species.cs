using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Models.Models
{
    public partial class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Breed> Breeds { get; set; }
    }
}
