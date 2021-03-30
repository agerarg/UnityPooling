using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    private float timeOut = 3f;
    private AudioSource audioSource;
    public void Setup()
    {
        timeOut = 3f;
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    void Update()
    {
        if (timeOut < 0)
        {
            ExploPooling.instance.ReturnToPool(this);
            //Destroy(gameObject);
        }
        timeOut -= Time.deltaTime;
    }
}
