namespace VehicleDescriptionAttributeReaderLateBinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LateBindingAttributeReflection.RunReflectAttributesUsingLateBinding();


            //In this latebinding, we copied the AttributeCarLibrary.dll to the bin folder while in earlybinding we reference it directly to the project
        }
    }
}