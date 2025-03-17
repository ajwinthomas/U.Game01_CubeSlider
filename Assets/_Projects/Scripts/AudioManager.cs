using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioSource btnAudioSource;
    private void Start()
    {
       audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    public void PlayButtonSound()
    {
        btnAudioSource.Play();
    }
}
