using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject target;
    public Projectile shotPrefab;
    public Punta puntaPrefab;
    public Transform puntaAim;
    void Update()
    {
        if(target!=null)
        {
            transform.LookAt(target.transform.position);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Punta newPunta = Instantiate(puntaPrefab, puntaAim.position, transform.rotation, puntaAim);

            //Projectile newShot = Instantiate(shotPrefab, transform.position, transform.rotation);
            //newShot.Setup();
            //Pooling
            Projectile newShot = ShootPoling.instance.Get();
            newShot.gameObject.SetActive(true);
            newShot.gameObject.transform.position = transform.position;
            newShot.gameObject.transform.rotation = transform.rotation;
            newShot.Setup();


        }

    }
}
