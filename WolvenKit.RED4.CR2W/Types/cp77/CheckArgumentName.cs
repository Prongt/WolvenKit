using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentName : CheckArguments
	{
		private CName _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CName CustomVar
		{
			get => GetProperty(ref _customVar);
			set => SetProperty(ref _customVar, value);
		}

		public CheckArgumentName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}