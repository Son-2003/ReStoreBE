using System.ComponentModel.DataAnnotations.Schema;

namespace ReStore.Entities
{
    [Table("BasketItems")]
    public class BasketItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //relationshop between basket and basketitem (1-n)
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}