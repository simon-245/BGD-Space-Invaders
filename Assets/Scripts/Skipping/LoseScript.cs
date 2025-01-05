using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LoseScript : MonoBehaviour
{
    public AudioSource gover;
    public int scores;
    public TextMeshPro scoreTMP;

    void Start()
    {
        //scores = PlayerPrefabs.GetInt("scores");
        gover = GetComponent<AudioSource>();
        gover.Play();
        //scoreTMP.text = ScoreManager.scoreText;
        //scoreTMP.text = "You've got: " + scores.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SpaceInvaders");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("WelcomeScene");
    }
}
