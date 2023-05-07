namespace Sadin.Common.ApplicationCommon.Queries;

public interface IQuery<TResult> : IRequest<Result<TResult>>
{
}