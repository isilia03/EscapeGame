using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoixMenuP : MonoBehaviour {

    public enum Scenes
    {
        Jeu,
        Regles
    }

    public GameObject Regles;

    public Scenes scenes;

    public void Jouer()
    {
        Application.LoadLevel("Jeu");
    }

    public void ReglesDuJeu()
    {
        Regles.SetActive(true);
    }
}
