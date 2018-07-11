using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VieJoueur : MonoBehaviour {

	private static int vie  = 3;
    public Text nombreDeVieRestantes;

    void Start()
	{
         nombreDeVieRestantes.text = vie.ToString();
	}
	public static void perteVie()
	{
		if ((ChoixReponse1.GetPerteVie() == 1) || (ChoixReponse2.GetPerteVie() == 1)) {
			if (vie > 1) {
				vie = vie -1;
				Debug.Log ("vous avez encore " + vie + "vies");
			} 

			else {
				Debug.Log ("Perdu");
                Points.setScore();
                Death.setMort();
                vie = 3;
            }
		}
	}

	public static int getVie()
	{
        return vie;
	}
}
