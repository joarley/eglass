namespace Rajastech.EGlass.Domain.Tests.Domain.Core
{
    using Rajastech.EGlass.Domain.Core;

    public class ValueObjectClass : ValueObject<ValueObjectClass>
    {
        public object P1 { get; private set; }
        public object P2 { get; private set; }

        public ValueObjectClass(object p1, object p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }
}
