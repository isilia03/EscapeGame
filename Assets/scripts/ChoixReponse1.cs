using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoixReponse1 : MonoBehaviour
{
    private string[] Reponses1 = new string[] { "L'étripeur", "Du sang", "Avec un pieu dans le coeur" };
    private string[] Reponses2 = new string[] { "1er Mai", "Une sorcière utilisant les pouvoirs de la nature", "4" };
    private string[] Reponses3 = new string[] { "Avec une table de ouija", "La nuit du jour de l'an", "Oui" };
    private string[] Reponses4 = new string[] { "Un serpent de mer", "Pétrifier", "incube" };
    private string[] Reponses5 = new string[] { "Cupidon", "Nouvelle lune", "La femme qui hurle" };

    private int[] Code_Verification1 = new int[] { 1, 0, 0 }; // 0 = bonne reponse 1 = mauvaise reponse
    private int[] Code_Verification2 = new int[] { 0, 0, 1 };
    private int[] Code_Verification3 = new int[] { 0, 1, 0 };
    private int[] Code_Verification4 = new int[] { 0, 0, 0 };
    private int[] Code_Verification5 = new int[] { 1, 1, 0 };

    private int reponse; // servira aussi a verifier si le joueur peut toujours avoir acces au contenu de cette pancarte
    public Text R1_text;
    public Text Affichage_reponse;
    private static int perte;
    private static int pancarte = 0;
    public GameObject panelBonneReponse;
    public GameObject panelPartieGagnee;

    void Start()
    {
        pancarte = AffichageQ1.GetPancarte();
        Debug.Log("R1: " + gestion_question1.GetN());

        switch (pancarte)
        {
            case 1:
                R1_text.text = Reponses1[gestion_question1.GetN()];
                break;

            case 2:
                R1_text.text = Reponses2[gestion_question1.GetN()];
                break;

            case 3:
                R1_text.text = Reponses3[gestion_question1.GetN()];
                break;

            case 4:
                R1_text.text = Reponses3[gestion_question1.GetN()];
                break;

            case 5:
                R1_text.text = Reponses5[gestion_question1.GetN()];
                break;

            default:
                Debug.Log("question inconnue");
                break;
        }
    }

    public void Choix()
    {
        switch (pancarte)
        {
            case 1:
                reponse = Code_Verification1[gestion_question1.GetN()];
                break;

            case 2:
                reponse = Code_Verification2[gestion_question1.GetN()];
                break;

            case 3:
                reponse = Code_Verification3[gestion_question1.GetN()];
                break;

            case 4:
                reponse = Code_Verification3[gestion_question1.GetN()];
                break;

            case 5:
                reponse = Code_Verification5[gestion_question1.GetN()];
                break;

            default:
                Debug.Log("code vérification inconnu");
                break;
        }

        if (reponse == 0)
        {
            perte = 0;
            AffichageQ1.enigme_resolue();
            Points.comptePoints();
            if (Points.getScore() < 3)
            {
                panelBonneReponse.SetActive(true);
            }

            else if (Points.getScore() == 3)
            {
                Points.setScore();
                panelPartieGagnee.SetActive(true);
            }
        }

        else
        {
            Debug.Log("vous avez perdu 1 vie");
            perte = 1;
            VieJoueur.perteVie();
            Affichage_reponse.text = "Faux, vous pouvez retenter votre chance ou passer à une autre question";
        }
    }

    public static int GetPerteVie()
    {
        return perte;
    }

    public static int getPancarte()
    {
        return pancarte;
    }
}