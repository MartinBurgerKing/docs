// <snippet1>
using System;
using System.Reflection;

namespace ReflectionModule_Examples
{
    class MyMainClass
    {
        static void Main()
        {
            Module[] moduleArray;
            
            moduleArray = typeof(MyMainClass).Assembly.GetModules(false);
            
            // In a simple project with only one module, the module at index
            // 0 will be the module containing these classes.
            Module myModule = moduleArray[0];

            Type[] tArray;

            tArray = myModule.FindTypes(Module.FilterTypeName, "My*");
            
            foreach(Type t in tArray)
            {
                Console.WriteLine("Found a module beginning with My*: {0}.", t.Name);
            }
        }
    }

    class MySecondClass
    {
    }

    // This class does not fit the filter criteria My*.
    class YourClass
    {
    }
}
// </snippet1>
