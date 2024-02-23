namespace P335_BackEnd.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();

        public int ImageId { get; set; }
        public Image Image { get; set; } = new();
    }
}
