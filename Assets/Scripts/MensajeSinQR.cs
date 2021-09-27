using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeSinQR : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void onTargetActive()
    {
        panel.SetActive(false);
    }

    public void onTargetNoActive()
    {
        panel.SetActive(true);
    }
}
