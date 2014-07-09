namespace Rajastech.EGlass.Application.DTO.StoreDTOs
{
    using Rajastech.EGlass.Application.DTO.Common;
    using System.Collections.Generic;

    public class StoreAddDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int StoreType { get; set; }
        public string Site { get; set; }
        public LocalizedContentDto StoreLocalizedDetails { get; set; }
        public IEnumerable<LocalizedContentDto> Addresses { get; set; }
        public IEnumerable<LocalizedContentDto> PhoneNumbers { get; set; }
    }
}
