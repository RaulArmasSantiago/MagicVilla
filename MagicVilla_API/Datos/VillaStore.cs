using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id = 1, Nombre= "Xalapa", Ocupantes=21, MetrosCuadrados=100},
            new VillaDto{Id = 2, Nombre= "Xico", Ocupantes=30, MetrosCuadrados=500}

        };
    }
}
