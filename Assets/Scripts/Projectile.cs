using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Explode explodePrefab;
    private float speed =10f;
    private AudioSource audioSource;
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Setup()
    {
        if(audioSource==null)
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void OnCollisionEnter(Collision collision)
    {

        //Explode exp = Instantiate(explodePrefab, transform.position, transform.rotation);
        //exp.Setup();

        Explode exp = ExploPooling.instance.Get();
        exp.gameObject.SetActive(true);
        exp.gameObject.transform.position = transform.position;
        exp.Setup();
        //Destroy(gameObject);
        //Pooling 
        ShootPoling.instance.ReturnToPool(this);
       
    }
}
