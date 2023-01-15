using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ApplyingAttributes
{

        //•  Attributes are classes that derive from System.Attribute.
        //•	 Attributes result in embedded metadata.
        //•	 Attributes are basically useless until another agent (including IDEs) reflects
        //   upon them.
        //•	 Attributes are applied in C# using square brackets.






    public class Motorcycle
    {
        [JsonIgnore]
        public float weightOfCurrentPassengers;
        // These fields are still serializable.
        public bool hasRadioSystem;
        public bool hasHeadSet;
        public bool hasSissyBar;
    }
}
