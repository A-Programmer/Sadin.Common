using Sadin.Common.Exceptions.Base;

namespace Sadin.Cms.Shared.Exceptions.Base;

public abstract class KSValidationException : KSException
{
    // TODO : Complete the implementation
    public KSValidationException(string message)
        : base(message)
    {
        
    }
}