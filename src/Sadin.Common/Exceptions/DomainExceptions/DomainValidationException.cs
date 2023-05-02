using Sadin.Common.Exceptions.Base;

namespace Sadin.Common.Exceptions.DomainExceptions;

public sealed class DomainValidationException : KSValidationException
{
    public DomainValidationException(string message)
        : base(message)
    {
        
    }
}