using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AffichageQuestion : MonoBehaviour {

	public Text Titre_Question;

	void Start()
	{
        //Debug.Log ("affichage question : " + AffichageQ1.GetPancarte());
        Titre_Question.text = "Question " + AffichageQ1.GetPancarte();
	}
}
