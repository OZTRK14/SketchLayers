using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1;
    [SerializeField] private ObjectPool objectPool;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }


    private IEnumerator SpawnRoutine()
    {
        while (true)
        {

            var obj =objectPool.GetPooleObject();
            obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(spawnInterval);
        }
     
    }
    

}
