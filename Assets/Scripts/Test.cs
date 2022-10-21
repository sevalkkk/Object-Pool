using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float spawnInternal = 1;
    [SerializeField] private ObjectPool objectPool = null;
    [SerializeField] private float sizeOfSpawnObject;
    public GameObject firstObject;
    Vector3 lastPos;

    private void Start()
    {
        StartCoroutine(nameof(spawnRoutine));
        sizeOfSpawnObject = firstObject.transform.localScale.z;
        lastPos = Vector3.zero;

    }
  
    private IEnumerator spawnRoutine()
    {
        int spawnCounter = 0;
        
        int rand = Random.Range(0, 5);
        while(true)
        {
            GameObject obj = null;
            if(rand >2)
            {

                obj = objectPool.GetPooledObject(0);
            }
            else
            {
                obj = objectPool.GetPooledObject(1);
            }
           
            spawnCounter++;
            lastPos = lastPos + new Vector3(0, 0, sizeOfSpawnObject);
            obj.transform.position = lastPos;

            yield return new WaitForSeconds(spawnInternal);
        }
    }


}
