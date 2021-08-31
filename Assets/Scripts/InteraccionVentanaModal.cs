using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionVentanaModal : MonoBehaviour
{
    public GameObject ventana;
    public GameObject ventana2;
    public string tipo;
    private void OnMouseDown()
    {
        if (tipo == "abrir")
        {
            ventana.SetActive(true);
        }
        if (tipo == "cerrar")
        {
            ventana.SetActive(false);
        }
        if (tipo == "video")
        {
            ventana.SetActive(true);
            ventana2.SetActive(false);
        }
        if (tipo == "volver")
        {
            ventana.SetActive(false);
            ventana2.SetActive(true);
        }
    }
}
