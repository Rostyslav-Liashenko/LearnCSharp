using IronPython.Hosting; // nuget IronPython
using Microsoft.Scripting.Hosting; // nuget DLR

namespace LearnDynamic
{
    static class IronPythonDemo
    {
        static void Main()
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.Execute("print 'hello, world'");
        }
    }
}
