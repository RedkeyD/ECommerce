namespace Application.Foundation.Result
{
    public class Result
    {
        public bool IsFailure => Error != null;

        public Error Error { get; set; }
        public IEnumerable<Warning> Warnings { get; set; }

        /// <summary>
        /// Успешный результат
        /// </summary>
        /// <returns></returns>
        public static Result Ok()
        {
            return new Result { Error = null, Warnings = null };
        }

        /// <summary>
        /// Успешный результат, но есть варнинги 
        /// </summary>
        /// <returns></returns>
        public static Result Ok( IEnumerable<Warning> warnings )
        {
            return new Result { Error = null, Warnings = warnings };
        }

        /// <summary>
        /// Результат с ошибкой
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result Fail( Error error )
        {
            return new Result { Error = error };
        }

        /// <summary>
        /// Результат с ошибкой и есть варнинги
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result Fail( Error error, IEnumerable<Warning> warnings )
        {
            return new Result { Error = error, Warnings = warnings };
        }
    }

    public abstract class Result<TResult, TData> : Result
     where TResult : Result<TResult, TData>, new()
     where TData : class
    {
        public TData Data { get; set; }

        public static TResult Ok( TData data )
        {
            return new TResult { Data = data, Error = null, Warnings = null };
        }

        public static TResult Ok( TData data, IEnumerable<Warning> warnings )
        {
            return new TResult { Data = data, Error = null, Warnings = warnings };
        }

        public new static TResult Fail( Error error )
        {
            return new TResult { Data = null, Error = error, Warnings = null };
        }

        public new static TResult Fail( Error error, IEnumerable<Warning> warnings )
        {
            return new TResult { Data = null, Error = error, Warnings = warnings };
        }
    }
}