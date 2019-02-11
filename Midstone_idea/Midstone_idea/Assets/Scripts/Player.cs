using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed;
    public float maxhp;
    public float hp;
    public float Mp;
    public float MaxMp;
    public float MPRechargeDelay;
    public float MPRechargeSpeed;
    
    public GameObject IceMissleobject;
    public GameObject IceSide;
    public GameObject FlameThrowerHbox;



    void Start()
    {
        movespeed = 5.0f;
        MaxMp = 100.0f;
        MPRechargeDelay = 3.0f;
        MPRechargeSpeed = 1.0f;
        Mp = MaxMp;
        IceSide = GameObject.Find("IceSide");


    }


    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward);
        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if (Input.GetButton("Lightning") & Mp > 0.0f)
        {

            FlameThrowerHbox.SetActive(true);
            Mp = Mp - 1.0f;

        }
        if (Input.GetButtonUp("Lightning"))
        {
            FlameThrowerHbox.SetActive(false);
        }

        if (Input.GetButton("Lightning") & Mp <= 0.0f)
        {
            FlameThrowerHbox.SetActive(false);
            Debug.Log("out of mana");
        }
        if (Input.GetButtonDown("Fire2") & Mp > 0.0f)
        {
            Instantiate(IceMissleobject, IceSide.transform.position, IceSide.transform.rotation);
            Mp -= 10.0f;
        }


    }








    IEnumerator Charging1()
    {


        yield return new WaitForSeconds(0.5f);
        FlameThrowerHbox.SetActive(true);
        Mp = Mp - 1;




    }





}
