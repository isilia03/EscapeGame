using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecupObjet : MonoBehaviour {

    public GameObject gemme;

    void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (Input.GetKeyDown("r")))
        {
            gemme.SetActive(false);
            JockerGemme.setNombreDeGemme();
        }
    }
}
