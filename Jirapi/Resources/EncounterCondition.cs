using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class EncounterCondition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }
        public List<NamedApiResource<EncounterConditionValue>> Values { get; set; }
    }
}