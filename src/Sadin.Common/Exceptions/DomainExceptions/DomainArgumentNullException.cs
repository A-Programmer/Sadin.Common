using Sadin.Common.Exceptions.Base;

namespace Sadin.Common.Exceptions.DomainExceptions;

public sealed class DomainArgumentNullException : KSArgumentNullException
{
    public DomainArgumentNullException(string paramName) : base(paramName)
    {
    }
}