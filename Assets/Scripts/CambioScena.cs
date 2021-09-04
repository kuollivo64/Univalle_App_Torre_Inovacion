using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena : MonoBehaviour
{
    public void LoadScena(string scenaName)
    {
        SceneManager.LoadScene(scenaName);
    }
}
