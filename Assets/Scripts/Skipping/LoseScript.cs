using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    public AudioSource gover;
 
    void Start()
    {
        gover = GetComponent<AudioSource>();
        gover.Play();
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
