using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private ObjectPool objectPool;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }


    private IEnumerator SpawnRoutine()
    {
        while (true)
        {

            var obj = objectPool.GetPooleObject();
            obj.GetComponent<Rigidbody>().AddForce(0, 0, 1000);
              obj.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y+2, Player.transform.position.z);
            //  obj.transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + 50), 1f);
            yield return new WaitForSeconds(spawnInterval);
        }

    }

}
