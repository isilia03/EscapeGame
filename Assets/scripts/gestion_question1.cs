using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestion_question1 : MonoBehaviour {

	private string[] Q1 = new string[] { "Quel est le surnom de Vlad Dracula ?", "Qu'utilisait Elisabeth Bathory pour conserver sa beauté ?", "Selon la légende comment un vampire peut-être tuer ?" };
	private string[] Q2 = new string[] {"Durant quelle date peut se dérouler un sabbat ?", "Qu'est-ce qu'une wicca ?", "En sorcellerie, combien compte-on d'éléments ?"};
	private string[] Q3 = new string[] {"Comment peut'on communiquer avec les esprits ?", "Durant quelle nuit la frontière entre le monde des esprits /net le nôtre est supposée être la plus fine ?", "Est-il possible de détecter des esprits ?"};
	private string[] Q4 = new string[] {"Qu'est-ce qu'un léviathan ?", "Quelle est la particularité des yeux du basilic ?", "Quel est le masculin de succube ?"};
	private string[] Q5 = new string[] {"Lequel est un archange ?", "Durant quelle phase lunaire un loup-garou peut-il se transformer ?", "Comment est surnommée la banshee ?"};

	public Text champ_question;
	private static int randomN = 0;
	private static int pancarte = 0;

	void OnEnable () {
		pancarte = AffichageQ1.GetPancarte ();

        switch (pancarte)
        {
            case 1:
                randomN = Random.Range(0, Q1.Length);
                champ_question.text = Q1[randomN];
                break;

            case 2:
                randomN = Random.Range(0, Q2.Length);
                champ_question.text = Q2[randomN];
                break;

            case 3:
                randomN = Random.Range(0, Q3.Length);
                champ_question.text = Q3[randomN];
                break;

            case 4:
                randomN = Random.Range(0, Q4.Length);
                champ_question.text = Q4[randomN];
                break;

            case 5:
                randomN = Random.Range(0, Q5.Length);
                champ_question.text = Q5[randomN];
                break;

            default:
                Debug.Log("pancarte inconnue");
                break;
        }

        Debug.Log("question numero " + randomN);
    }

	public static int GetN() {
		return randomN;
	}

	public static int GetPancarte()
	{
		return pancarte;
	}
}
