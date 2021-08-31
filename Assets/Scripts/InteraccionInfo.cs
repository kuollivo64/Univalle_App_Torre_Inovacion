using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionInfo : MonoBehaviour
{
    public string URL;

    private void OnMouseDown()
    {
        Application.OpenURL(URL);
    }


}
