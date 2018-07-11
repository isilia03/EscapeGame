using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JockerGemme : MonoBehaviour {

    private static int nombreDeGemmes = 0;

    public static void setNombreDeGemme()
    {
        nombreDeGemmes = nombreDeGemmes + 1;

        if (nombreDeGemmes == 2)
        {
            Debug.Log("partie finie");
            //Application.LoadLevel("FinGood");
        }
    }
}
