using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Store
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
            {
                new VillaDTO() {Id=1,Name="Bikash",Occupancy =1,SqFt=234},
                new VillaDTO() {Id=2,Name="Aikash",Occupancy =13,SqFt=2334}
            };
    }
}
