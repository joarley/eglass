namespace Rajastech.EGlass.Infrastructure.CrossCutting.Validation
{
    using System;
    using System.Collections.Generic;

    public interface IValidation<T>
    {
        IEnumerable<ValidationResult> Validate(T value);
    }
}
