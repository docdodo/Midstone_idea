using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScipt : MonoBehaviour {
    public Transform spawnPos;
    public Transform spawnie;
	
	
	void Update () {
		if (Input.GetMouseButton(0))
        {
            Instantiate(spawnie, spawnPos.position, spawnPos.rotation);
        }

	}
}
