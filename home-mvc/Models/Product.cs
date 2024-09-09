using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComWindowTeam.ClientMvc.Models
{
[Table("Product")] // Đặt tên bảng là 'Product'
public class Product
{
    [Key]
    [Column("id")] // Đặt tên cột là 'id'
    public int Id { get; set; }

    [Column("categoryid")] // Đặt tên cột là 'categoryid'
    public int CategoryId { get; set; }

    [Column("name")] // Đặt tên cột là 'name'
    public required string Name { get; set; }

    [Column("price")] // Đặt tên cột là 'price'
    public double Price { get; set; }
}
}

