using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Store
{
    public class VilllaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
            {
                new VillaDTO() {Id=1,Name="Bikash"},
                new VillaDTO() {Id=2,Name="Aikash"}
            };
    }
}
