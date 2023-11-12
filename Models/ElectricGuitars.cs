using System;
namespace GuitarStoreWebApp.Models
{
	public class ElectricGuitars
	{
		public ElectricGuitars()
		{
		}

		public int GuitarID { get; set; }
		public int BrandID { get; set; }
		public string Model { get; set; }
		public double Price { get; set; }
		public string Color { get; set; }
		public int StringNum { get; set; }
		public int PickupNum { get; set; }
		public int FretNum { get; set; }
		public int BodyStyle { get; set; }
		public int PickupBridgeType { get; set; }
        public int PickupMiddleType { get; set; }
        public int PickupNeckType { get; set; }
		public int PickupExtra { get; set; }
		public byte[] Image { get; set; }

		public IEnumerable<Brand> BrandsList { get; set; }
        public IEnumerable<Pickups> PickupsList { get; set; }
        public IEnumerable<BodyStyle> BodyStyleList { get; set; }
    }
}