using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AffichageQ1 : MonoBehaviour {

	private bool affichage;
	public GameObject loupe_rouge;
	public GameObject loupe_verte;
	public int P;
	private static int pancarte = 0;
	private static bool[] resolue = new bool[] {false, false, false, false, false}; // pancarte dont l enigme a ete resolue ou non

	void Start () {
		affichage = false;
		loupe_rouge.SetActive(false);
		loupe_verte.SetActive(false);
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			pancarte = P;
			if (resolue[pancarte-1] == false) {
				loupe_rouge.SetActive (true);
				loupe_verte.SetActive (false);
				affichage = true;
			} 

			else if (resolue[pancarte-1] == true) 
			{
				loupe_rouge.SetActive (false);
				loupe_verte.SetActive (true);
				affichage = false;
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			//TxtQuestion.GetComponent<Text> ().enabled = false;
			loupe_rouge.SetActive(false);
			loupe_verte.SetActive (false);
			affichage = false;
		}
	}

	void Update(){
		if (affichage == true) {
			if (Input.GetMouseButtonDown (0)) {
                Application.LoadLevel("Question");
			}
		}
	}

	public static int GetPancarte()
	{
		return pancarte;
	}

	public static void enigme_resolue()
	{
		resolue[pancarte-1] = true;
	}
}
