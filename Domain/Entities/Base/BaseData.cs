namespace Domain.Entities.Base
{
	public class BaseData
	{
		public Guid Id { get; set; }
		public int IdNguoiTao { get; set; }
		public DateTime NgayTao { get; set; }
		public int? IdNguoiSua { get; set; }
		public DateTime? NgaySua { get; set; }
		public bool DaXoa { get; set; }
	}
}
