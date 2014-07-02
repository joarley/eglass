namespace Rajastech.EGlass.Infrastructure.CrossCutting.Validation
{
    using System;

    public class ValidationResult
    {
        public Guid ErrorId { get; set; }
        public Guid Message { get; set; }
    }
}
