using Sadin.Common.Exceptions.Base;

namespace Sadin.Common.Exceptions.InfrastructureExceptions;

public sealed class InfrastructureArgumentNullException : KSArgumentNullException
{
    public InfrastructureArgumentNullException(string paramName) : base(paramName)
    {
    }
}