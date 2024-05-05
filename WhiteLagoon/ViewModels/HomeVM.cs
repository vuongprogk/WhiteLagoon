using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Web.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Villa> Villas { get; set; }
        public DateOnly CheckInDay { get; set; }
        public int Nights { get; set; }
        public DateOnly CheckOutDay { get; set; }

    }
}
