using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Models.Models
{
    public partial class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int SpeciesId { get; set; }
        public Species Species { get; set; }

        public ICollection<Dog> Dogs { get; set; }
    }
}
