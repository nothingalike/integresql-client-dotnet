namespace Nothingalike.Integresql.Client.Exceptions;

public class TestNotFoundException : IntegresqlException
{
    public TestNotFoundException() : base("test database not found") { }
}