namespace RinhaBackend.Transacoes;

public static class RotasTransacoes
{
    public static void AddRotasTransacoes(this WebApplication app)
    {
        app.MapGet("clientes/extrato", () => "Extrato");
    }
}
