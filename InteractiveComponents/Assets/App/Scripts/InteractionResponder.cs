using TMPro;
using UnityEngine;

public class InteractionResponder : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _text;

    [SerializeField]
    private AudioClip _focusAudio;

    [SerializeField]
    private AudioClip _focusLostAudio;


    [SerializeField]
    private AudioClip _startTouchAudio;

    [SerializeField]
    private AudioClip _endTouchAudio;

    private int _timesClicked = 0;

    private int _timesTouched = 0;


    public void Click()
    {
        _timesClicked++;
        UpdateText();
    }

    
    public void TouchStart()
    {
        _timesTouched++;
        UpdateText();
        PlayClip(_startTouchAudio);
    }

    public void TouchEnd()
    {
        PlayClip(_endTouchAudio);
    }

    public void OnFocus()
    {
        PlayClip(_focusAudio);
    }

    public void OnFocusLost()
    {
        PlayClip(_focusLostAudio);
    }

    private void UpdateText()
    {
        _text.text = $"Clicked: {_timesClicked} Touched: {_timesTouched}";
    }

    private void PlayClip(AudioClip clip)
    {
        if (clip == null)
        {
            return;
        }
        var audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }

        audioSource.clip = clip;
        audioSource.Play();
    }
}
