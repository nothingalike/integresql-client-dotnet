using System.Threading.Tasks;
using Nothingalike.Integresql.Client.Models;

namespace Nothingalike.Integresql.Client;

public interface IIntegresqlDatabaseClient
{
    Task<TestDatabase> GetDatabase(string hash);
    Task ReturnDatabase(TestDatabase database);
}