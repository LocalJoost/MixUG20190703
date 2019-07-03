using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace Assets.App.Scripts
{
    public class GrabResponder : MonoBehaviour, IMixedRealityInputHandler
    {
        public void OnInputUp(InputEventData eventData)
        {
            Debug.Log(eventData.MixedRealityInputAction.Description);
        }

        public void OnInputDown(InputEventData eventData)
        {

        }
    }
}
