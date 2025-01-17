using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_CurveFloatValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("curveData")] 
		public CLegacySingleChannelCurve<CFloat> CurveData
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(12)] 
		[RED("argument")] 
		public animFloatLink Argument
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_CurveFloatValue()
		{
			Id = 4294967295;
			Argument = new();
		}
	}
}
