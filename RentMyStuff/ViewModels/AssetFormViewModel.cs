using RentMyStuff.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentMyStuff.Web.ViewModels
{
    public class AssetFormViewModel
    {
        public IEnumerable<AssetTypeDto> AssetTypes { get; set; }
        public AssetDto Asset { get; set; }
    }
}
