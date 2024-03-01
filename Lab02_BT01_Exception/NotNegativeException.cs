using System.Runtime.Serialization;

[Serializable]
internal class NotNegativeException : Exception
{
	public NotNegativeException()
	{
	}

	public NotNegativeException(string? message) : base(message)
	{
	}

	public NotNegativeException(string? message, Exception? innerException) : base(message, innerException)
	{
	}

	protected NotNegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
	{
	}
}