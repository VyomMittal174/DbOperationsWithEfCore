using System.ComponentModel.DataAnnotations;

namespace DbOperationsWithEfCoreApp.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CurrencyTypeId { get; set; }
        public int Amount { get; set; }

        public Book Book { get; set; }
        public CurrencyType Currency { get; set; }
    }
}
