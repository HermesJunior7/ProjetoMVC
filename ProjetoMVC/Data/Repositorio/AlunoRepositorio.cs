using ProjetoMVC.Data.Repositorio.Interfaces;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }
}
