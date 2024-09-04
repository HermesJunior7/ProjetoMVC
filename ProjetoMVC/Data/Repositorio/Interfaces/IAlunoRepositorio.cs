using ProjetoMVC.Models;

namespace ProjetoMVC.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);

	}
}
