using ProjetoUd1.Data;
using ProjetoUd1.Models;

namespace ProjetoUd1.Services
{
    public class SellerService
    {
        private readonly BancoContext _bancoContext;
        public SellerService(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<SellerModel> FindAll()
        {
            return _bancoContext.Seller.ToList();
        }
    }
}
