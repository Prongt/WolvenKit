using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerVehicleHorsepower : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("horsepower")] 
		public CInt32 Horsepower
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
