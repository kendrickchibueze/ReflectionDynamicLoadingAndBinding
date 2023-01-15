namespace AttributedCarLibrary
{
    // A custom attribute.


    //Remember that an attribute is quite useless until another piece of software reflects over its values



    // This time, we are using the AttributeUsage attribute
    // to annotate our custom attribute.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string description) => Description = description;
        public VehicleDescriptionAttribute() { }
    }

    //With this, if a developer attempted to apply the [VehicleDescription] attribute on anything other than 
   // a class or structure, they are issued a compile-time error.
}