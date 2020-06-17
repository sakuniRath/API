﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartApp.DataAccessLayer.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        [Required]
        public double Discount { get; set; }
        [Required]
        public string ShipAddress { get; set; }
       
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        public virtual Customer Customers { get; set; }
       public virtual Payment Payments { get; set; }
       public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
