namespace QuizMe.Domain.Application.Results
{
    public struct ValidatedResult<T>
    {
        private bool _success;
        public bool Success => _success is not false && _value is not null ? true : false;
        private T _value;
        public T? Value => Success is not true
            ? default(T)
            : _value ?? throw new Exception("There has been an internal error with the validated result.");

        private uint _code;
        public uint Code => _code;

        private string? _failure_message;
        public string FailureMessage => string.IsNullOrWhiteSpace(_failure_message) is true
            ? "No failure message has been provided"
            : _failure_message;

        public static ValidatedResult<T> Failed(uint code = 0, string? failure_message = null) => new()
        {
            _success = false,
            _code = code,
            _failure_message = failure_message
        };

        public static ValidatedResult<T> Passed(T value, uint code = 0) => new()
        {
            _success = true,
            _value = value,
            _code = code
        };
    }
}
