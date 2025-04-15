using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Models.Models
{
    public partial class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public int BreedId { get; set; }
        public Breed Breed { get; set; }
    }
}
