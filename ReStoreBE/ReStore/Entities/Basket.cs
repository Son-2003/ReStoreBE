using System.Collections.Generic;
using System.Linq;

namespace ReStore.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public string buyerId { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        
        //public void AddItem(Product product, int quantity) { 
        //    if(Items.All(item => item.ProductId != product.Id))
        //    {
        //        Items.Add(new BasketItem { Product = product, Quantity = quantity })
        //    }
        //    var existingItem = Items.FirstOrDefault(item => item.)

        //}
    }
}
