namespace Sadin.Common.Exceptions.Base;

public abstract class KSArgumentNullException : KSException
{
    public KSArgumentNullException(string paramName)
        : base($"Value cannot be null. (Parameter name: '{paramName}')")
    {
    }
}