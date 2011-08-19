using System.Reflection;

namespace TechTalk.SpecFlow.Bindings
{
    public class EventBinding : MethodBinding
    {
        public string[] Tags { get; private set; }

        public EventBinding(string[] tags, MethodInfo methodInfo)
            : base(methodInfo)
        {
            Tags = tags;
        }
    }
}