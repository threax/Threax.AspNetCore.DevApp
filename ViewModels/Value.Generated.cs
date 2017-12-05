using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Halcyon.HAL.Attributes;
using Threax.AspNetCore.Halcyon.Ext;
using Threax.AspNetCore.Halcyon.Ext.UIAttrs;
using Threax.AspNetCore.Tracking;
using DevApp.Models;
using DevApp.Controllers.Api;

namespace DevApp.ViewModels 
{
       public partial class Value : IValue, IValueId , ICreatedModified
       {
        public Guid ValueId { get; set; }

        [UiOrder(0, 18)]
        public String Name { get; set; }

        [UiOrder(0, 2147483646)]
        public DateTime Created { get; set; }

        [UiOrder(0, 2147483647)]
        public DateTime Modified { get; set; }

    }
}
