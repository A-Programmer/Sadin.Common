namespace Sadin.Common.Abstractions;

public interface IValidationResult
{
    public static readonly Error ValidationError = new(
        "ValidationError",
        "Validation problem occured.");
    
    Error[] Errors { get; }
}