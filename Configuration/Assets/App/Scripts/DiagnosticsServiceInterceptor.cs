using App.Services;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Diagnostics;
using TMPro;
using UnityEngine;

public class DiagnosticsServiceInterceptor : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _text;

    // Update is called once per frame
    void Update()
    {
        var manager = MixedRealityToolkit.Instance.GetService<IMixedRealityDiagnosticsSystem>();

        // var manager = MixedRealityToolkit.DiagnosticsSystem;

        if (Input.GetKeyDown(KeyCode.R))
        {
            manager.ShowDiagnostics = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            manager.ShowDiagnostics = false;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            var service = MixedRealityToolkit.Instance.GetService<IMyTestService>();
            _text.text = service.GetDataUrl();
        }

    }
}
