using AttributedCarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDescriptionAttributeReader
{
    //    If you want to make use of early binding, you’ll require the client
    //application to have a compile-time definition of the attribute in question(VehicleDescriptionAttribute,
    //in this case). Given that the AttributedCarLibrary assembly has defined this custom attribute as a public
    //class, early binding is the best option.
    internal class EarlyBindingAttributeReflection
    {



        public static void Run()
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            ReflectOnAttributesUsingEarlyBinding();
            Console.ReadLine();
        }

        public static void ReflectOnAttributesUsingEarlyBinding()
                {
                    // Get a Type representing the Winnebago.
                    Type t = typeof(Winnebago);

                    // Get all attributes on the Winnebago.
                    object[] customAtts = t.GetCustomAttributes(false);

                    // Print the description.
                    foreach (VehicleDescriptionAttribute v in customAtts)
                    {
                        Console.WriteLine("-> {0}\n", v.Description);
                    }
                }
    }
}

//cmd
//dotnet add VehicleDescriptionAttributeReader reference .\AttributedCarLibrary