using ProjetoUd1.Models.Enums;

namespace ProjetoUd1.Models
{
    public class SalesRecordModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public SellerModel Seller { get; set; }

        public SalesRecordModel() { }

        public SalesRecordModel(int id, DateTime date, double amount, SaleStatus status, SellerModel seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
