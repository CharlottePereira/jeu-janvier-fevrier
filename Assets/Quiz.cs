using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
 
    private Text TextQuestion;
    private Text TxtScore;
    private int Nr = 0;
    private TextMesh TxtBtnG;
    private TextMesh TxtBtnD;
    public string Reponse;
    public int Score = 0;
    public int TotalQuestion = 7;
    private int NbQuestion = 0;

    string[] Quizz = new string[7];

    // Start is called before the first frame update
    void Start()
    {

        TextQuestion = GameObject.Find("TextQuestion").GetComponent<Text>();
        TxtScore = GameObject.Find("TxtScore").GetComponent<Text>();
        TxtBtnD = GameObject.Find("texte droit").GetComponent<TextMesh>();
        TxtBtnG = GameObject.Find("texte gauche").GetComponent<TextMesh>();

        Quizz[0] = "2 + 2 = 4 ?,Vrai,Faux,Vrai";
        Quizz[1] = "Les Game2 sont trop cools ?,Vrai,Faux,Vrai";
        Quizz[2] = "il y a 9 films Harry Potter ?,Vrai,Faux,Faux";
        Quizz[3] = "La terre est plate ?,Vrai,Faux,Faux";
        Quizz[4] = "Les guépards sont les animaux les plus rapides sur terre ?,Vrai,Faux,Vrai";
        Quizz[5] = "christophe colomb a découvert l'Amérique ?,Vrai,Faux,Vrai";
        Quizz[6] = "Un Chewing-gum met 9 ans a se décomposer ?,Vrai,Faux,Faux";

       

        PoseUneQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if (NbQuestion < TotalQuestion)
        {
            TxtScore.text = "Score: " + Score;
        }
    }

    public void PoseUneQuestion()
    {
        if (NbQuestion < TotalQuestion)
        {
            NbQuestion += 1;
            //Nr = Random.Range(0, Quizz.Length);
            
            string[] Col = Quizz[Nr].Split(',');
            TextQuestion.text = Col[0];
            TxtBtnG.text = Col[1];
            TxtBtnD.text = Col[2];
            Reponse = Col[3];
        }
        else
        {
            Debug.Log("Quizz terminé, votre score est de " + Score + "/" + TotalQuestion);
            TxtScore.text = "Quizz terminé, votre score est de " + Score + "/" + TotalQuestion;
        }
        Nr += 1;
    }
}
