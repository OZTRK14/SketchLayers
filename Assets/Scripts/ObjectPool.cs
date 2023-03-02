using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private Queue<GameObject> pooleObjects;
   
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private int poolSize;
    private void Awake()
    {
     
        pooleObjects = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {

            GameObject obj = Instantiate(objectPrefab);
            obj.GetComponent<Rigidbody>().AddForce(0, 0, 1000);
            pooleObjects.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    public GameObject GetPooleObject()
    {
        GameObject obj= pooleObjects.Dequeue();
        obj.SetActive(true);
        pooleObjects.Enqueue(obj);
        return obj;
    }

}
