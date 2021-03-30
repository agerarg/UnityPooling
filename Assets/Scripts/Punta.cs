using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punta : MonoBehaviour
{
    float timeOut = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeOut < 0)
            Destroy(gameObject);
        timeOut -= Time.deltaTime;
    }
}
