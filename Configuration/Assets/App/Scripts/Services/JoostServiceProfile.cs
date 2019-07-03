using System;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Extensions;

namespace Microsoft.MixedReality.Toolkit.Extensions
{
	[MixedRealityServiceProfile(typeof(IJoostService))]
	[CreateAssetMenu(fileName = "JoostServiceProfile", menuName = "MixedRealityToolkit/JoostService Configuration Profile")]
	public class JoostServiceProfile : BaseMixedRealityProfile
	{
		// Store config data in serialized fields
	}
}