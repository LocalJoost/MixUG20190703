using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

namespace MRTKExtensions.Animations
{
    /// <summary>
    /// Very simple behavior to keep something dead ahead of the user
    /// </summary>
    public class StickInView : MonoBehaviour
    {
        public float Distance = 1.0f;

        private float distance;

        private void Start()
        {
#if !UNITY_EDITOR
            distance = Distance;
#else
            distance = Distance / 3;
#endif
        }

        void Update()
        {
            var position = CameraCache.Main.transform.position + CameraCache.Main.transform.forward.normalized * distance;
            transform.position = position;
        }
    }
}
