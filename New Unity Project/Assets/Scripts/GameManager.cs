using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score = 0;
    public Text ScoreText;


    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

}
