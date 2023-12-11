using System.Collections.Generic;
using System.Text.Json.Serialization;
using Nothingalike.Integresql.Client.Exceptions;
using Nothingalike.Integresql.Client.Models;

namespace Nothingalike.Integresql.Client.RequestModels;

internal class DatabaseConfigResponse
{
    [JsonPropertyName("host")] public string? Host { get; set; }
    [JsonPropertyName("port")] public int? Port { get; set; }
    [JsonPropertyName("username")] public string? Username { get; set; }
    [JsonPropertyName("password")] public string? Password { get; set; }
    [JsonPropertyName("database")] public string? Database { get; set; }
    [JsonPropertyName("additionalParams")] public Dictionary<string, string>? AdditionalParams { get; set; }

    public DatabaseConfig ToModel() => new(
        Host ?? throw new InternalErrorException("host in response was null"),
        Port ?? 5432,
        Username,
        Password,
        Database ?? throw new InternalErrorException("database name in response was null"),
        AdditionalParams ?? new Dictionary<string, string>()
    );
}