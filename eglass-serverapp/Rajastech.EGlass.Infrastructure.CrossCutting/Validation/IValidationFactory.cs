using System;
namespace Rajastech.EGlass.Infrastructure.CrossCutting.Validation
{

    /// <summary>
    /// Base contract for Log abstract factory
    /// </summary>
    public interface IValidationFactory
    {
        /// <summary>
        /// Create a new ILog
        /// </summary>
        /// <returns>The ILog created</returns>
        IValidation<T> Create<T>();
    }
}
