namespace Rajastech.EGlass.Infrastructure.CrossCutting
{
    using Validation;
    using System;
    using System.Collections.Generic;

    public class ValidateException: Exception
    {
        public ValidateException(IEnumerable<ValidationResult> result)
        {

        }

        public ValidateException(ValidationResult result)
        {

        }
    }
}
