using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RentMyStuff.Core.Models
{
    public class AssetType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
