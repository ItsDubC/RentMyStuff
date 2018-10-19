using RentMyStuff.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RentMyStuff.Web.ViewModels
{
    public class AssetFormViewModel
    {
        public AssetFormViewModel()
        {
            Id = 0;
        }
        public IEnumerable<AssetTypeDto> AssetTypes { get; set; }
        //public AssetDto Asset { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Type")]
        public byte AssetTypeId { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(0, 256)]
        public int NumberInStock { get; set; }

        //[Display(Name = "Number Available")]
        //[Range(0, 256)]
        //public int NumberAvailable { get; set; }
    }
}
