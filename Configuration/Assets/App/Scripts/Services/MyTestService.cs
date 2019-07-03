using System;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

namespace App.Services
{
	[MixedRealityExtensionService(SupportedPlatforms.WindowsStandalone|SupportedPlatforms.MacStandalone|SupportedPlatforms.LinuxStandalone|SupportedPlatforms.WindowsUniversal)]
	public class MyTestService : BaseExtensionService, IMyTestService, IMixedRealityExtensionService
	{
		private MyTestServiceProfile newServiceMyTestServiceProfile;

		public MyTestService(IMixedRealityServiceRegistrar registrar,  string name,  uint priority,  BaseMixedRealityProfile profile) : base(registrar, name, priority, profile) 
		{
			newServiceMyTestServiceProfile = (MyTestServiceProfile)profile;
		}

		public override void Initialize()
		{
			// Do service initialization here.
		}

		public override void Update()
		{
			// Do service updates here.
		}

        public string GetDataUrl()
        {
            return newServiceMyTestServiceProfile.DataUrl;
        }
	}
}