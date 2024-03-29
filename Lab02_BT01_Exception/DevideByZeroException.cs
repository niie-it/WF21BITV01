﻿using System.Runtime.Serialization;

[Serializable]
internal class DevideByZeroException : Exception
{
	public DevideByZeroException()
	{
	}

	public DevideByZeroException(string? message) : base(message)
	{
	}

	public DevideByZeroException(string? message, Exception? innerException) : base(message, innerException)
	{
	}

	protected DevideByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
	{
	}
}