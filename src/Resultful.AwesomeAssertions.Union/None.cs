#if FLUENTASSERTIONS
namespace FluentAssertions.Union
#else
namespace Resultful.AwesomeAssertions.Union
#endif
{
    public class None
    {
        private None()
        {
            
        }

        public static None Value { get; } = new None();
    }
}
