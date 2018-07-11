using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bouton_quitter_jeu : MonoBehaviour
{

    public Button bouton_Q;

    void Start()
    {
        Button btn = bouton_Q.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
    }
}
