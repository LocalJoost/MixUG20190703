using System;
using Microsoft.MixedReality.Toolkit;

namespace App.Services
{
	public interface IMyTestService : IMixedRealityExtensionService
    {
        string GetDataUrl();
    }
}