using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectController : MonoBehaviour
{
    public bool shouldRunWithXrRig;
    public GameObject fpsController;
    public GameObject xRRig;

    private void Awake()
    {
        if (shouldRunWithXrRig)
        {
            xRRig.SetActive(true);
            fpsController.SetActive(false);
        }
        else
        {
            xRRig.SetActive(false);
            fpsController.SetActive(true);
        }
    }
}
