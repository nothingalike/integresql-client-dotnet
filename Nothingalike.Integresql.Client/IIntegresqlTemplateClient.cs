using System.Threading.Tasks;
using Nothingalike.Integresql.Client.Models;

namespace Nothingalike.Integresql.Client;

public interface IIntegresqlTemplateClient
{
    Task<TemplateDatabase> InitializeTemplate(string hash);
    Task FinalizeTemplate(TemplateDatabase database);
    Task DiscardTemplate(TemplateDatabase database);
}