using System;

public class ExtensionException : Exception
{
    public const string MSG_MANAGER_INITIALIZATION_ERROR = "Manager initialization failed!";
    public const string MSG_MANAGER_CORE_NULL = "Core can not be set to null!";
    public const string MSG_MANAGER_CORE_GET_NULL = "Core can not be get as null!";

    public const string MSG_MODULE_NULL = "Attempt to register module failed. Module can not be null!";
    public const string MSG_MODULE_CANNOT_REGISTER = "Module {0} could not be registered! Application already initialized!";
    public const string MSG_MODULE_CANNOT_UNREGISTER = "Module {0} could not be unregistered! Application already initialized!";

    public ExtensionException()
    {

    }

    public ExtensionException(string message, params object[] arguments) : base(string.Format(message, arguments))
    {

    }

    public ExtensionException(Exception exception, string message, params object[] arguments) : base(string.Format(message, arguments), exception)
    {

    }
}
