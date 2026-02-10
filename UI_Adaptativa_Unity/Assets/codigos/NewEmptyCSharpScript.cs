using UnityEngine;

public class LogicaEnlacesWeb : MonoBehaviour
{
    // Este método se llama desde el botón
    public void AbrirEnlace(string url)
    {
        Application.OpenURL(url);
    }
}
