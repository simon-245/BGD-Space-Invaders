using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float moveDistance = 1f;
    public float moveForward = -1f;

    bool isMovingRight = true;

    public float timeStep = 1f;
    public float countdown;

    // I added a switch to try both methods
    public bool isUsingCountdown = true;

    void Start()
    {
        if (isUsingCountdown)
        {
            countdown = timeStep;
        }
        else
        {
            // Invoke repeating will be called once after timeStep (2nd parameter) amount,
            // and then repeatedly every timeStep (3rd parameter) amount
            InvokeRepeating("Move", timeStep, timeStep);
        }
    }

    void Update()
    {
        if (isUsingCountdown)
        {
            countdown -= Time.deltaTime;

            if (countdown <= 0)
            {
                Move();
                countdown = timeStep;
            }
        }
    }

    void Move()
    {
        if (isMovingRight)
        {            
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);

            if (newPos.x >= maxPosX)
            {
                isMovingRight = false;
                MoveStepForward();
            }
 
            else
            {
                transform.position = newPos;
            }
        }
        else
        {
            
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);

            if (newPos.x <= minPosX)
            {
                isMovingRight = true;
                MoveStepForward();
            }

            else
            {
                transform.position = newPos;
            }
        }
    }

    void MoveStepForward()
    {
        Vector3 currentY = transform.position;
        Vector3 newY = currentY + new Vector3(0f, moveForward);
        transform.position = newY;

        if (transform.position.y <= -4)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}