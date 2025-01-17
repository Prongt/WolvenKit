using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsTargetObjectPlayer : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("targetObject")] 
		public CHandle<AIArgumentMapping> TargetObject
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
