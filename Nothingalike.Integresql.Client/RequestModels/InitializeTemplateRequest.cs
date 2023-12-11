using System.Text.Json.Serialization;

namespace Nothingalike.Integresql.Client.RequestModels;

internal class InitializeTemplateRequest
{
    [JsonPropertyName("hash")] public string? Hash { get; set; }
}