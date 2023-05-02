using Sadin.Common.Exceptions.Base;

namespace Sadin.Common.Exceptions.DomainExceptions;

public class DomainEntityNotFoundException : KSEntityNotFoundException
{
    public DomainEntityNotFoundException(Guid id) : base(id)
    {
    }
}