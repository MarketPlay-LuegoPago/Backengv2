using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backengv2.Dtos
{
    public class CouponsDto
    {

          public string? Name { get; set; }
          public string? Description { get; set; }
          public DateTime CreationDate { get; set; }
          public DateTime ActivationDate { get; set; }
          public DateTime expiration_date { get; set; }
          public string? DiscountType { get; set; }
          public decimal DiscountValue { get; set; }
          public string? UseType { get; set; }
          public int quantity_uses { get; set; }
          public decimal MinPurchaseAmount { get; set; }
          public decimal MaxPurchaseAmount { get; set; }
          public string? status { get; set; }
          public int RedemptionLimit { get; set; }
          public int CurrentRedemptions { get; set; }
          public int MarketingUserId { get; set; } 
    }
}