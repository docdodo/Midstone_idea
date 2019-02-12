using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float movespeed;
    public float maxhp;
    public float hp;
    public Slider healthSlider;
    public Slider MpSlider;
    public float Mp;
    public float MaxMp;
    public float MPRechargeDelay;
    public float MPRechargeDelayRate;
    public float MPRechargeDelaymax;
    public float MPRechargeSpeed;
    public float hpRechargeSpeed;
    public float hpRechargedelay;
    public float hpRechargedelaymax;
    public float hpRechargedelayRate;
   
    public GameObject IceMissleobject;
    public GameObject IceSide;
    public GameObject FlameThrowerHbox;



    void Start()
    {
        movespeed = 5.0f;
        MaxMp = 100.0f;
        maxhp = 100.0f;
        hp = 100.0f;
        MPRechargeDelay = 4.0f;
        hpRechargedelay = 15.0f;
        MPRechargeDelaymax = 4.0f;
        hpRechargedelaymax = 15.0f;
        MPRechargeDelayRate = 1.0f;
        hpRechargedelayRate = 1.0f;
        hpRechargeSpeed= 0.1f;
        MPRechargeSpeed = 1.0f;
        Mp = MaxMp;
        IceSide = GameObject.Find("IceSide");
        healthSlider.maxValue = maxhp;
        healthSlider.value = hp;
        MpSlider.maxValue = MaxMp;
        MpSlider.value = Mp;



    }


    void Update()
    {
        
        Debug.DrawRay(transform.position, transform.forward);
        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if(!Input.GetButton("Lightning")&!Input.GetButton("Fire2"))
        {
            MPRechargeDelay -= Time.deltaTime * MPRechargeDelayRate;
        }
        else if (MPRechargeDelay!=MPRechargeDelaymax)
        {
            MPRechargeDelay = MPRechargeDelaymax;
        }
        if(MPRechargeDelay<=0&&Mp<MaxMp)
        {
            Mp += MPRechargeSpeed;
            MpSlider.value = Mp;
        }
        if(MaxMp<Mp)
        {
            Mp = MaxMp;
        }
        if (hp < maxhp)
        {
            hpRechargedelay -= Time.deltaTime * hpRechargedelayRate;
        }
        if (hpRechargedelay <= 0 && hp < maxhp)
        {
            hp += hpRechargeSpeed;
            healthSlider.value = hp;
        }

        if (Input.GetButton("Lightning") & Mp > 0.0f)
        {

            FlameThrowerHbox.SetActive(true);
            Mp = Mp - 1.0f;
            MpSlider.value = Mp;

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
            MpSlider.value = Mp;
        }


    }








    IEnumerator Charging1()
    {


        yield return new WaitForSeconds(0.5f);
        FlameThrowerHbox.SetActive(true);
        Mp = Mp - 1;
        MpSlider.value = Mp;




    }
    public void takeDamage(float damage)
    {
        hp -= damage;
        healthSlider.value = hp;
        hpRechargedelay = hpRechargedelaymax;
    }





}
