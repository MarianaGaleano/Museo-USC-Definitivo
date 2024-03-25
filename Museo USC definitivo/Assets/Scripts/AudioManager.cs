using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        // Obtener el componente AudioSource del objeto actual o agregar uno si no existe
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Desactivar la reproducción automática del audio al iniciar el juego
        audioSource.playOnAwake = false;
    }

    public void PlayAudio(AudioClip audioClip)
    {
        // Reproducir el audio
        if (audioClip != null && audioSource != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No se ha asignado ningún AudioClip para reproducir.");
        }
    }
}
