using UnityEngine;

public class ReproducirAudio : MonoBehaviour
{
    public Camera cam;
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform == this.transform)
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause();
                }
                else
                {
                    audioSource.Play();
                }
            }
        }
    }
}
