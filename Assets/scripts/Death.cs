using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public static bool mort = false;
    public GameObject panelDeath;

    public static void setMort()
    {
        mort = true;
    }

    void Update()
    {
        if (mort == true)
        {
            panelDeath.SetActive(true);
        }
    }
}
