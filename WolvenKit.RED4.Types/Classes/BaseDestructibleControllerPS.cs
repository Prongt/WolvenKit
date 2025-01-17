using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseDestructibleControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("destroyed")] 
		public CBool Destroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseDestructibleControllerPS()
		{
			DeviceName = "LocKey#127";
			TweakDBRecord = new() { Value = 86578523053 };
			TweakDBDescriptionRecord = new() { Value = 137459607504 };
		}
	}
}
