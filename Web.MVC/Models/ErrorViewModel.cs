using System;
using Tier.Entities.Concrete;

namespace Web.MVC.Models
{
    public class ErrorViewModel : ResponseModel<int>
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
