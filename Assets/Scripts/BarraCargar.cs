using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BarraCargar : MonoBehaviour
{
    public GameObject pantallaCarga;
    public GameObject logoUnivalle;

    public void CargarNivel(int numScene){
        StartCoroutine(cargar(numScene));
    }
    IEnumerator cargar(int numScene){
        AsyncOperation operacion = SceneManager.LoadSceneAsync(numScene);
        pantallaCarga.SetActive(true);
        logoUnivalle.SetActive(false);
        while (!operacion.isDone)
        {
            yield return null;
        }
    }
}




