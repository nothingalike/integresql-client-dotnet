using System.Text.Json.Serialization;
using Nothingalike.Integresql.Client.Exceptions;
using Nothingalike.Integresql.Client.Models;

namespace Nothingalike.Integresql.Client.RequestModels;

internal class InitializeTemplateResponse
{
    [JsonPropertyName("database")] public DatabaseResponse? Database { get; set; }

    public TemplateDatabase ToModel() => new(
        Database?.TemplateHash ?? throw new InternalErrorException("database hash in response was null"), 
        Database?.Config?.ToModel() ?? throw new InternalErrorException("database config in response was null")
    );
}