using RentMyStuff.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentMyStuff.Web.ViewModels
{
    public class CreateAssetViewModel
    {
        public IEnumerable<AssetType> AssetTypes { get; set; }
        public Asset Asset { get; set; }
    }
}
