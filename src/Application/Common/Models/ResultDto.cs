namespace QCheck.Application.Common.Models;
public class ResultDto<T>
{
    public ResultDto(T data, bool isSuccess, string message, string errorDetails)
    {
        Data = data;
        IsSuccess = isSuccess;
        Message = message;
        ErrorDetails = errorDetails;
    }

    public ResultDto(T data, bool isSuccess, string message)
    {
        Data = data;
        IsSuccess = isSuccess;
        Message = message;
        ErrorDetails = string.Empty;
    }

    public ResultDto(T data, bool isSuccess)
    {
        Data = data;
        IsSuccess = isSuccess;
        Message = string.Empty;
        ErrorDetails = string.Empty;
    }

    public T Data { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public string ErrorDetails { get; set; }
}
