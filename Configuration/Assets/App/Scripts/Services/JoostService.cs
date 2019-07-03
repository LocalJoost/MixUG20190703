using System;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Extensions;

namespace Microsoft.MixedReality.Toolkit.Extensions
{
	[MixedRealityExtensionService(SupportedPlatforms.WindowsStandalone|SupportedPlatforms.MacStandalone|SupportedPlatforms.LinuxStandalone|SupportedPlatforms.WindowsUniversal)]
	public class JoostService : BaseExtensionService, IJoostService, IMixedRealityExtensionService
	{
		private JoostServiceProfile joostServiceProfile;

		public JoostService(IMixedRealityServiceRegistrar registrar,  string name,  uint priority,  BaseMixedRealityProfile profile) : base(registrar, name, priority, profile) 
		{
			joostServiceProfile = (JoostServiceProfile)profile;
		}

		public override void Initialize()
		{
			// Do service initialization here.
		}

		public override void Update()
		{
			// Do service updates here.
		}
	}
}