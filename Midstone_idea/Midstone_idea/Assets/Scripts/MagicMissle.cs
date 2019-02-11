using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMissle : MonoBehaviour
{
    public GameObject MissleTarget;
    public bool havetarget;
    public Vector3 Missletarget2;
    public float speed;
    void Start()
    {

        havetarget = false;

    }

    // Update is called once per frame
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

        if (other.gameObject.tag == "Enemy")
        {

            MissleTarget = other.gameObject;
            Missletarget2 = MissleTarget.gameObject.transform.position;
            havetarget = true;

        }
    }
}
