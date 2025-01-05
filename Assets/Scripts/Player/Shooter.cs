using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
 //   public float timeValue = 90f;
   // public TextMeshPro TimerText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CountTime(timeValue);
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    /*void CountTime(float someTime)
    {
        if (someTime > 0) {
            float minutes = Mathf.FloorToInt(someTime / 60);
            float seconds = Mathf.FloorToInt(someTime % 60);
            TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            someTime -= Time.deltaTime;
        } 
        else
        {
            someTime = 0;
            SceneManager.LoadScene("LoseScene");
        }
    }*/
}
