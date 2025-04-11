using college_management.Contextos;
using college_management.Models;
using Microsoft.EntityFrameworkCore;

namespace college_management.Dados.Repositorios
{
	public class RepositorioUsuarios : RepositorioBase<Usuario>, IRepositorioUsuarios
	{
		public RepositorioUsuarios(CollegeDbContext context) : base(context)
		{
		}

		public async Task<Usuario> ObterPorLoginAsync(string login)
		{
			return await _dbSet
				.FirstOrDefaultAsync(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase));
		}

		public async Task<bool> ValidarCredenciaisAsync(string login, string senha)
		{
			var usuario = await ObterPorLoginAsync(login);
			if (usuario == null) return false;

			// Em um sistema real, você deve usar hash da senha e salt
			return usuario.Senha == senha;
		}
	}
}
