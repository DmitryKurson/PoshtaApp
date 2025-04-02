using PoshtaApp.Models;

namespace PoshtaApp.ViewModels
{
    public class HomeViewModel
    {
        public List<City> Cities { get; set; }
        public List<Obl> Oblasti { get; set; }
        public List<Raj> Kraji { get; set; }
        public List<Aup> Indexes { get; set; }
    }

}
