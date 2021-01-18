using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reponse : MonoBehaviour
{

    void OnMouseDown()
    {
        if (GameObject.Find("Canvas").GetComponent<Quiz>().Reponse == transform.GetChild(0).GetComponent<TextMesh>().text)
        {
            Debug.Log("Gagné");
            GameObject.Find("Canvas").GetComponent<Quiz>().Score +=1;
        }
        else
        {
            Debug.Log("Perdu");
        }

        GameObject.Find("Canvas").GetComponent<Quiz>().PoseUneQuestion();

    }

}