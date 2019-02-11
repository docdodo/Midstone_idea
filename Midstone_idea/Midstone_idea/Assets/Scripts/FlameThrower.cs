using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Health>().changeHP(-5.0f);


        }
    }
}
