using api_concessionaria.Interface;
using API_CONCESSIONARIA.Contexts;
using API_CONCESSIONARIA.Models;

namespace api_concessionaria.Repositório
{
    public class Veiculos_repository : IVeiculosRepository
    {
        private readonly ConcessionariaContext _context;
        public Veiculos_repository(ConcessionariaContext context)
        {
            _context = context;
        }
        public void cadastrar(Veiculo veiculo)
        {
            _context.Veiculo.Add(veiculo);   // coloca na fila (marca para inserir)
            _context.SaveChanges();
        }

        public List<Veiculo> ListarTodos()
        {
            return _context.Veiculo.ToList();
        }
    }
}
