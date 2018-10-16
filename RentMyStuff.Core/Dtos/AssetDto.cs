using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RentMyStuff.Core.Dtos
{
    public class AssetDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        public byte AssetTypeId { get; set; }

        public AssetTypeDto AssetType { get; set; }

        [Required]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}
