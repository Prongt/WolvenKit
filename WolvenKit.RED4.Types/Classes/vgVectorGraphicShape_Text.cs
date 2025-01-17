using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Text : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] 
		[RED("xt")] 
		public CString Xt
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public vgVectorGraphicShape_Text()
		{
			CalTransform = new();
		}
	}
}
