using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajastech.EGlass.Application.DTO.StoreDTOs
{
    public class StoreAddDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int StoreType { get; set; }
        public string Site { get; set; }
        public LocalizedContentDTO StoreLocalizedDetails { get; set; }
        public IEnumerable<LocalizedContentDTO> Addresses { get; set; }
    }
}
