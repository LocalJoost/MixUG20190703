using System;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;

namespace App.Services
{
	[MixedRealityServiceProfile(typeof(IMyTestService))]
	[CreateAssetMenu(fileName = "MyTestServiceProfile", menuName = "MixedRealityToolkit/MyTestService Configuration Profile")]
	public class MyTestServiceProfile : BaseMixedRealityProfile
    {
        [SerializeField]
        private string _dataUrl;

        public string DataUrl => _dataUrl;
    }
}