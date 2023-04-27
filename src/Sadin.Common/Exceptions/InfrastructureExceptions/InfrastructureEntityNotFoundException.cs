namespace Sadin.Common.Exceptions.InfrastructureExceptions;

public class InfrastructureEntityNotFoundException : KSEntityNotFoundException
{
    public InfrastructureEntityNotFoundException(Guid id)
        : base(id)
    {
    }
}