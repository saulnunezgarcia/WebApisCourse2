using MagicVilla_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModel
{
    public class NumeroVillaUpdateViewModel
    {
        public NumeroVillaUpdateViewModel()
        {
            NumeroVilla = new NumeroVillaUpdateDto(); 
        }
        public NumeroVillaUpdateDto NumeroVilla { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}
