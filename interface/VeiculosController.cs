using API_CONCESSIONARIA.Models;

namespace api_concessionaria.Interface
{
    public interface IVeiculosRepository
    {
        List <Veiculo> ListarTodos ();

        public void cadastrar(Veiculo marca);
    }
}
