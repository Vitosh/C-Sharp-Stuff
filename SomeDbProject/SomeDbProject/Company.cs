using System.Collections.Generic;

namespace SomeDbProject
{
    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int YearEstablished { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
