using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlMouseButton
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlNoButton = 0,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlPrimaryButton = 1,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlSecondaryButton = 2
	}
}