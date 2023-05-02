namespace Sadin.Common.Exceptions.Base;

public abstract class KSEntityNotFoundException : KSException
{
    public KSEntityNotFoundException(Guid id)
        : base($"The entity with the id {id} could not be found.")
    {
    }
}