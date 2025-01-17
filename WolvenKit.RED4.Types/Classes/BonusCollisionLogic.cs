using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BonusCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		[Ordinal(3)] 
		[RED("hasTriggered")] 
		public CBool HasTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
