using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxhp;
    public float hp;
    public float expworth;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxhp;
        Player = GameObject.Find("Player");
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void changeHP(float change) //works with taking damage and healing. Use it in attacks
    {
        hp = hp + change;
        if (hp <= 0)
        {
            Player.GetComponent<LevelSystem>().gainExp(expworth);
            Destroy(transform.parent.gameObject);
            //die
        }
    }
}
