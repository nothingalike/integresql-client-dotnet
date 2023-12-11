using System;

namespace Nothingalike.Integresql.Client.Exceptions;

public abstract class IntegresqlException : Exception
{
    public IntegresqlException(string message) : base(message) { }
}