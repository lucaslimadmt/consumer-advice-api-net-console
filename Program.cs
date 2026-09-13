using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Console;

var endpointUrl = "https://api.adviceslip.com/advice";

WriteLine("Iniciando requisição para obter dados de um conselho:");
WriteLine(endpointUrl);
WriteLine();

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(endpointUrl);
    response.EnsureSuccessStatusCode();

    string responseString = await response.Content.ReadAsStringAsync();

    AdviceSlipResponse? adviceResponse = JsonSerializer.Deserialize<AdviceSlipResponse>(responseString);

    if (adviceResponse?.Slip != null)
    {
        WriteLine("Conselho de Hoje:");
        WriteLine(adviceResponse.Slip.Advice);
    }
}
catch (Exception e)
{
    WriteLine("Aconteceu um erro ao consultar a api: " + e.Message);
}

public class AdviceSlipResponse
{
    [JsonPropertyName("slip")]
    public AdviceSlip? Slip { get; set; }
}

public class AdviceSlip
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("advice")]
    public string? Advice { get; set; }
}