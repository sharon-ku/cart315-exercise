using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    private Vector3 state = new Vector3();
    public float moveChance = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float randomA = Random.value;

        if(randomA < moveChance)
        {
            float randomB = Random.value;

            if (randomB < 0.33f)
            {
                state = new Vector3(0, 0, 0);
            }
            else if (randomB < 0.66f)
            {
                state = new Vector3(1, 0, 0);
            }
            else
            {
                state = new Vector3(-1, 0, 0);
            }
        }

        this.transform.Translate(state * 0.1f);
    }
}
