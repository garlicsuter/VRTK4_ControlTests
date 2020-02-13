using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SnitchBall : MonoBehaviour
{
    public int Score = 0;
    public TMP_Text ScoreText;

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "snitch")
        //{
        //    Debug.Log("Gooooooaaaaaal!");
        //    Score += 1;
        //    UpdateScore();
        //}
        if (collision.gameObject.CompareTag("snitch")){

            Debug.Log("Goal?");

        }
    }


    void UpdateScore()
    {
        ScoreText.SetText(Score.ToString());
    }
}
