using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissle : MonoBehaviour
{

    public GameObject MissleTarget;
    public bool havetarget;
    public Vector3 Missletarget2;
    public float speed;
    void Start()
    {
        speed = 8.0f;
        havetarget = false;

    }

    void Update()
    {

        if (havetarget == true)
        {

            transform.LookAt(Missletarget2);
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Missletarget2, step);
        }

        Debug.DrawRay(transform.position, transform.forward);




    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            MissleTarget = other.gameObject;
            Missletarget2 = MissleTarget.gameObject.transform.position;
            havetarget = true;

        }
    }
}
