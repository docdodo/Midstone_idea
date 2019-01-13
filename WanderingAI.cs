using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI: MonoBehaviour {

    public float WalkSpeed = 3f;
    public float rotSpeed = 100f;


    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }

        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }

        if (isRotatingLeft == true)
            transform.position += transform.forward * WalkSpeed * Time.deltaTime;
        }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 3);
        int rotateLorR = Random.Range(0, 3);
        int WalkWait = Random.Range(1, 4);
        int WalkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(WalkWait);
        isWalking = true;

        yield return new WaitForSeconds(WalkTime);
        isWalking = false;

        yield return new WaitForSeconds(rotateWait);
        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;

        }
        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }

        isWandering = false;

    }

    








}
