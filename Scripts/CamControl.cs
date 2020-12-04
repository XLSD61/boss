using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamControl : MonoBehaviour
{
   // public GameObject player;
     Vector3 AradakiMesafe;


    //--------- Public UI-------
    public Text scoreText;
    public Text goldText;
    public Text highScoreText;
    public Text deadScoreText;
    public Text deadGoldText;
    public Text diamondText;

    public static int score;
    public static int goldCount;
    public static int diamondCount;

    public Transform player;
    void Start()
    {
        AradakiMesafe = transform.position - player.transform.position;
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }


    void LateUpdate()
    {

        transform.position = player.transform.position + AradakiMesafe;
        transform.LookAt(player);


    }
    private void Update()
    {
                 // Oyun Ekranı//
        scoreText.text = " " + score; // Skor

        goldText.text = " " + goldCount; // Altın

        diamondText.text = " " + diamondCount; // Elmas

        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }

        // Dead Panel// 

        deadScoreText.text = " " + score;
        deadGoldText.text = " " + goldCount;
       //PlayerPrefs.SetInt("gold", int.Parse(deadGoldText.text));
        


    }

}
