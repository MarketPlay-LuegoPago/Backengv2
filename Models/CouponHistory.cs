using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backengv2.Models
{
    public class CouponHistory
    {
    [Key]
    public int id { get; set; }
    
    public DateTime ChangeDate { get; set; }
    public string? FieldChanged { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public int CouponId { get; set; } 
    public Coupon? Coupon { get; set; }
    public int ?ChangedByUser { get; set; }
    public MarketingUser? MarketingUser { get; set; }

   
  }
}