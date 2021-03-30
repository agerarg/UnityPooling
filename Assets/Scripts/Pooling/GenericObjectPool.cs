using System.Collections.Generic;
using UnityEngine;

public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component
{
   
    public T prefab;

    public static GenericObjectPool<T> instance { get; private set; }
    private Queue<T> objects = new Queue<T>();

    private void Awake()
    {
        instance = this;
    }

    public T Get()
    {
        if (objects.Count == 0)
            AddObject();
        return objects.Dequeue();
    }

    public void ReturnToPool(T objectToReturn)
    {
        objectToReturn.gameObject.SetActive(false);
        objects.Enqueue(objectToReturn);
    }

    public void AddObject()
    {
        var newObject = GameObject.Instantiate(prefab,transform.position, Quaternion.identity, transform);
        newObject.gameObject.SetActive(true);
        objects.Enqueue(newObject);
    }
}
