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
namespace DevApp.Database 
{
    public class ValueEntity : IValue, IValueId , ICreatedModified
    {
        [Key]
        public Guid ValueId { get; set; }

        [MaxLength(450)]
        public String Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}