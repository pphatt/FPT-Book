using System;
using System.Collections.Generic;

namespace FPTBook.Models;

public partial class ImageBook
{
    public int ImageId { get; set; }

    public string? BookImage { get; set; }

    public int? BookId { get; set; }

    public virtual Book? Book { get; set; }
}
