using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public float exp;
    public float maxexp;
    public int skillpoints;
    // Start is called before the first frame update
    void Start()
    {
        exp = 0.0f;
        maxexp = 100.0f;
    }

    public void gainExp(float gain)
    {
        exp = exp + gain;
        if (exp >= maxexp)
        {
            exp = 0.0f;
            maxexp += 100.0f;
            skillpoints += 1;
        }
    }
}
