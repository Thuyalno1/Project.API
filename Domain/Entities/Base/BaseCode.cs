namespace Domain.Entities.Base
{
	public class BaseCode
	{
		public int Id { get; set; }
		public string Ma { get; set; }
		public string Ten { get; set; }
		/// <summary>
		/// True - đang hoạt động
		/// False - không hoạt động
		/// </summary>
		public bool HoatDong { get; set; }
	}
}
