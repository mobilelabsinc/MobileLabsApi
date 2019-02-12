using System;

namespace MobileLabs.DeviceConnect.RestApi
{
    public class OperationResult<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }

    public class AsyncStatusModel
    {
        public bool IsComplete { get; set; }
        public object Data { get; set; }
    }
}
