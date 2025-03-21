using System.Text.Json.Serialization;

namespace Bellon.API.ConsumoInterno.Classes;

[Serializable]
public class LSCentralUnidadMedidaArray
{
    [JsonPropertyName("@odata.context")]
    public Uri odataContext { get; set; }

    [JsonPropertyName("value")]
    public LSCentralUnidadMedida[] value { get; set; }
}
