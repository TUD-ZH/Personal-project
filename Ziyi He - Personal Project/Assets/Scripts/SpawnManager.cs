using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //create array
    public GameObject[] christmasPrefabs;
    public int index;
    public float xRange;

    // Start is called before the first frame update
    void Start()
    {

    //objects will appear in repetedly every second
        InvokeRepeating(nameof(SpawnObject), 2, 1);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObject()
    {

    //random
        float xPos = Random.Range(-xRange, xRange);
        index = Random.Range(0, christmasPrefabs.Length);
        Instantiate(christmasPrefabs[index], new Vector3(xPos,0f,-75f), christmasPrefabs[index].transform.rotation);

    }
}
