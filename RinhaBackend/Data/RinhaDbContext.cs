using Microsoft.EntityFrameworkCore;
using RinhaBackend.Entities;

namespace RinhaBackend.Data;

public class RinhaDbContext(DbContextOptions<RinhaDbContext> options) : DbContext(options)
{
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Transacao> Transacoes => Set<Transacao>();
}

