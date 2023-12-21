using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel;

public class Result
{
    public Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None
            || !isSuccess && error != Error.None)
        {
            throw new ArgumentException("Invalid error", nameof(error));
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }
    public Error Error { get; }

    public bool IsFailure => !IsSuccess;

    public static Result Success() => new(true, Error.None);

    //public static Result<TValue> Success<TValue>(TValue value) => new(value, Error.None);

    public static Result Failure(Error error) => new(false, error);

    //public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);
}
