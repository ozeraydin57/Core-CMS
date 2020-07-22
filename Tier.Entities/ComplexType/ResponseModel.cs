using System;
using System.Collections.Generic;
using System.Text;
using Tier.Entities.ComplexType;

namespace Tier.Entities.Concrete
{
    public class ResponseModel<T> : BaseViewModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
