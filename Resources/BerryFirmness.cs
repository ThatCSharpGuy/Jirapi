using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class BerryFirmness
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedApiResource<Berry>> Berries { get; set; }
        public List<Name> Names { get; set; }
    }
}