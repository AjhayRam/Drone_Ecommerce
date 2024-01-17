


using ECommerce.API.Models;

namespace Ecommerce.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; } = new Product();
    }
}
