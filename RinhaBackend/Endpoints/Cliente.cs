using RinhaBackend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RinhaBackend.Endpoints;

public static class Cliente
{
    public static async Task<IResult> GetClientes([FromServices] RinhaDbContext context)
    {
        var clientes = await context.Clientes.ToListAsync();
        return Results.Ok(clientes);
    }

}
