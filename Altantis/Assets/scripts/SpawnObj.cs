using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject[] trash;
    
    public void SpawnTrash()
    {

        StartCoroutine(SpawnAfter());
    
    
    
    }

   IEnumerator SpawnAfter()
    {
        yield return new WaitForSeconds(1);
        GameObject trashSpawn = Instantiate(trash[Random.Range(0, trash.Length)], this.transform) as GameObject;
        trashSpawn.transform.localPosition = new Vector3(Random.Range(-3000f, 3000f), Random.Range(0f, 89f), Random.Range(2000f, -1000f));
    }
  

}
