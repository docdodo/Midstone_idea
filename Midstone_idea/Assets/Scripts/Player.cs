using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float movespeed;
    public float maxhp;
    public float hp;
    public float Mp;
    public float MaxMp;
    public GameObject LightningHbox;
    void Start () {
        movespeed = 5.0f;
        MaxMp = 100.0f;
        Mp = MaxMp;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.forward);
        transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if (Input.GetButton("Lightning") & Mp > 0.0f)
        {

            LightningHbox.SetActive(true);
            Mp = Mp - 0.1f;

        }
        if(Input.GetButtonUp("Lightning"))
        {
            LightningHbox.SetActive(false);
        }
        
        if (Input.GetButton("Lightning") & Mp <= 0.0f)
        {
            LightningHbox.SetActive(false);
            Debug.Log("out of mana");
        }


    }
 









    IEnumerator Charging1()
    {
        
            
            yield return new WaitForSeconds(0.5f);
            LightningHbox.SetActive(true);
        Mp = Mp - 1;
        
            
        

    }





}
