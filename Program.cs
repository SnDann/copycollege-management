using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using college_management.Contextos;
using college_management.Dados;
using college_management.Models;
using college_management.Servicos;

// Build configuration
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

// Configure services
var services = new ServiceCollection();

// Configure SQLite connection
services.AddDbContext<CollegeDbContext>(options =>
    options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

// Register repositories
services.AddScoped<IRepositorio<Aluno>, RepositorioBase<Aluno>>();
services.AddScoped<IRepositorio<Curso>, RepositorioBase<Curso>>();
services.AddScoped<IRepositorio<Disciplina>, RepositorioBase<Disciplina>>();
services.AddScoped<IRepositorio<Matricula>, RepositorioBase<Matricula>>();
services.AddScoped<IRepositorio<Professor>, RepositorioBase<Professor>>();
services.AddScoped<IRepositorio<Turma>, RepositorioBase<Turma>>();
services.AddScoped<IRepositorio<Usuario>, RepositorioBase<Usuario>>();

// Register services
services.AddScoped<IServico<Aluno>, ServicoBase<Aluno>>();
services.AddScoped<IServico<Curso>, ServicoBase<Curso>>();
services.AddScoped<IServico<Disciplina>, ServicoBase<Disciplina>>();
services.AddScoped<IServico<Matricula>, ServicoBase<Matricula>>();
services.AddScoped<IServico<Professor>, ServicoBase<Professor>>();
services.AddScoped<IServico<Turma>, ServicoBase<Turma>>();
services.AddScoped<IServico<Usuario>, ServicoBase<Usuario>>();

var serviceProvider = services.BuildServiceProvider();

// Ensure database is created
using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<CollegeDbContext>();
    context.Database.EnsureCreated();
}

// Get repositories and create base data
using (var scope = serviceProvider.CreateScope())
{
    var baseDeDados = new BaseDeDados(
        scope.ServiceProvider.GetRequiredService<IRepositorio<Aluno>>(),
        scope.ServiceProvider.GetRequiredService<IRepositorio<Curso>>(),
        scope.ServiceProvider.GetRequiredService<IRepositorio<Disciplina>>(),
        scope.ServiceProvider.GetRequiredService<IRepositorio<Matricula>>(),
        scope.ServiceProvider.GetRequiredService<IRepositorio<Professor>>(),
        scope.ServiceProvider.GetRequiredService<IRepositorio<Turma>>()
    );

    // Autenticação
    Console.WriteLine("Sistema de Gerenciamento Acadêmico");
    Console.WriteLine("----------------------------------");
    
    // Aqui você pode implementar o menu principal e a lógica de navegação
    // baseada no tipo de usuário (Administrador, Professor ou Aluno)
    
    Console.WriteLine("\nPressione qualquer tecla para sair...");
    Console.ReadKey();
}
