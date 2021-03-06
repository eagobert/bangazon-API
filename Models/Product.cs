using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bangazon_inc.Data;

namespace bangazon_inc.Models
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }
    [Required]
    public double Price { get; set;}
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    // customer id foreign key
    public int CustomerId { get; set;}
    public Customer Customer { get; set; }
    [Required]
    // category id foreign key
    public int CategoryId { get; set;}
    public ProductType ProductType { get; set; }

    public virtual ICollection<OrderProduct> ProductOrders {get; set;}

  }
}