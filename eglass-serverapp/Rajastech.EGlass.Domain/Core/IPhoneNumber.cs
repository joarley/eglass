namespace Rajastech.EGlass.Domain.Core
{
    using System;

    public interface IPhoneNumber : IEntity
    {
        string GetFormatedNumber();
        string GetFullPhoneNumber();
        string Type { get; }
    }
}
