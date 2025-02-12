using AplicattionMVC.Models; 

namespace AplicattionMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        ContatoModel Atualizar(ContatoModel contato);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
