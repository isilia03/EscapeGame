using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

	private static int score = 0; // sert a compter le nombre d enigmes resolue avant la fin de partie pour la fin on doit obetnir un score de 3

	public static void comptePoints()
	{
		score = score + 1;
	}

	public static int getScore()
	{
		return score;
	}

	public static void setScore()
	{
		score = 0;
	}
}
