using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcScript : MonoBehaviour
{
    
    // Update is called once per frame
    public void PlayAGame()
    {
        SceneManager.LoadScene("SpaceInvaders");
    }
}
