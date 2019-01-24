using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform SpawnPos;
    public GameObject spawnie;
	
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Instantiate(spawnie, SpawnPos.position, SpawnPos.rotation);
        }
	}
}
