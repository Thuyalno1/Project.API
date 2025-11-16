namespace Domain.Entities.Base
{
	public class BaseTree : BaseCode
	{
		public int? IdCha { get; set; }
		/// <summary>
		/// |IdCu||IdOng||IdCha|
		/// </summary>
		public string DuongDan { get; set; }
		/// <summary>
		/// bắt đầu từ 0
		/// </summary>
		public int Capdo { get; set; }
	}
}
