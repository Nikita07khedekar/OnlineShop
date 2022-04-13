using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModelLayer;

namespace UserInterface.ViewModel
{
    public class AddAddressViewModel
    {
        public AspNetUser AspNetUser { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
    }
}