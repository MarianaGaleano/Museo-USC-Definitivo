using UnityEngine;
using UnityEngine.UI;

public class MostrarImagen : MonoBehaviour
{
    public Camera cam;
    public GameObject imagenCanvas;
    public GameObject miraObject; // Agrega el objeto Mira aquí

    void Start()
    {
        // Al iniciar la escena, asegúrate de que el objeto Canvas esté desactivado
        imagenCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform == this.transform)
            {
                MostrarCanvas(true);
                OcultarMira(true); // Mostrar imagen, ocultar mira
            }
            else
            {
                MostrarCanvas(false);
                OcultarMira(false); // Ocultar imagen, mostrar mira
            }
        }
    }

    void MostrarCanvas(bool activar)
    {
        imagenCanvas.SetActive(activar);
    }

    void OcultarMira(bool activar)
    {
        miraObject.SetActive(!activar);
    }
}
