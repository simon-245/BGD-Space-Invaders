using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public AudioSource win;

    void Start()
    {
        win = GetComponent<AudioSource>();
        win.Play();
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
