using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class PlayMusic : MonoBehaviour, IPointerClickHandler
{
    private AudioSource audio;
    private Text buttonDescription;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        buttonDescription = GetComponentInChildren<Text>();
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (audio.isPlaying == true)
        {
            audio.Stop();
            if (buttonDescription != null)
            {
                buttonDescription.text = "Play music";
            }
        }
        else
        {
            audio.Play();
            if (buttonDescription != null)
            {
                buttonDescription.text = "Stop music";
            }
        }
    }
}
