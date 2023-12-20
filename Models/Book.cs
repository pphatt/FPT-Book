using System;
using System.Collections.Generic;

namespace FPTBook.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string BookTitle { get; set; } = null!;

    public int BookPrice { get; set; }

    public int BookNumber { get; set; }

    public string? BookDetails { get; set; }

    public int PublisherId { get; set; }

    public int? AuthorId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<ImageBook> ImageBooks { get; set; } = new List<ImageBook>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Publisher Publisher { get; set; } = null!;

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
