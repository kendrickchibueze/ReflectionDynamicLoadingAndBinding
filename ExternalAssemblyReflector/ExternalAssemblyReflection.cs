using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAssemblyReflector
{
    internal class ExternalAssemblyReflection
    {

        public static void RunExternalAssemblyReflection()
        {
            //Formally speaking, the act of loading external assemblies on demand is known as a dynamic load.

            //System.Reflection defines a class named Assembly.Using this class, you can dynamically load an
            //assembly, as well as discover properties about the assembly itself

            //todo
            //. Your task is to construct code that prompts for the name of an assembly (minus any extension) to load dynamically



            Console.WriteLine("***** External Assembly Viewer *****");
            string asmName = "";
            Assembly asm = null;
            do
            {
                Console.WriteLine("\nEnter an assembly to evaluate");
                Console.Write("or enter Q to quit: ");
                // Get name of assembly.
                asmName = Console.ReadLine();
                // Does user want to quit?
                if (asmName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                // Try to load assembly.
                try
                {
                    asm = Assembly.LoadFrom(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find assembly.");
                }
            } while (true);
            static void DisplayTypesInAsm(Assembly asm)
            {
                Console.WriteLine("\n***** Types in Assembly *****");
                Console.WriteLine("->{0}", asm.FullName);
                Type[] types = asm.GetTypes();
                foreach (Type t in types)
                {
                    Console.WriteLine("Type: {0}", t);
                }
                Console.WriteLine("");
            }
        }
    }
}
