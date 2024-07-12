using Application.Foundation.Result;

namespace Application.Abstractions.Validators
{
    public interface IAsyncValidator<in TData>
    {
        Task<Result> ValidateAsync( TData data );
    }
}
