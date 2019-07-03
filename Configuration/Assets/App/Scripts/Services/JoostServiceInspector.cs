#if UNITY_EDITOR
using System;
using Microsoft.MixedReality.Toolkit.Editor;
using Microsoft.MixedReality.Toolkit.Extensions;
using UnityEngine;
using UnityEditor;

namespace Microsoft.MixedReality.Toolkit.Extensions.Editor
{	
	[MixedRealityServiceInspector(typeof(JoostService))]
	public class JoostServiceInspector : BaseMixedRealityServiceInspector
	{
		public override void DrawInspectorGUI(object target)
		{
			JoostService service = (JoostService)target;
			
			// Draw inspector here
		}
	}
}

#endif