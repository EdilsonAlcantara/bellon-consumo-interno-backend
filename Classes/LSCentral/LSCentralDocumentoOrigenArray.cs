using System.Text.Json.Serialization;

namespace Bellon.API.ConsumoInterno.Classes;

[Serializable]
public class LSCentralDocumentoOrigenArray
{
    [JsonPropertyName("@odata.context")]
    public Uri odataContext { get; set; }

    [JsonPropertyName("value")]
    public LSCentralDocumentoOrigen[] value { get; set; }
}
