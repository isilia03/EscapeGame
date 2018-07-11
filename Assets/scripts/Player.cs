using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private static bool detruit = false;

    void Awake()
    {
        if(! detruit)
        {
            DontDestroyOnLoad(this.gameObject);
            detruit = true;
        }
    }
}
