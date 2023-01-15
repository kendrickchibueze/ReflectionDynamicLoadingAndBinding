using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace ExternalAssemblyReflector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ExternalAssemblyReflection.RunExternalAssemblyReflection();

           //FrameworkAssemblyViewer.RunFrameworkAssemblyViewer();

            LateBinding.RunLateBinding();

















            //Adding a reference to a class library and downloading and using a nugget package are the same but different
            //from manually copying the .dll file to the bin directory of
            //the project. The first one is at compile time while the second is at runtime and is used for latebinding




            //However, because your program has not added a reference to CarLibrary.dll, you cannot use the C# 
            //using keyword to import the CarLibrary namespace, and therefore, you cannot use a MiniVan type during
            //the casting operation!
            
            //Remember that the whole point of late binding is to create instances of objects for 
            //which there is no compile-time knowledge.
        }
    }
}