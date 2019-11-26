using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubePool : MonoBehaviour
{

	public GameObject cubeToPool;
	public int amountOfCubes;
	List<GameObject> pooledCubes;
 
    // Use this for initialization
    void Start ()
    {


        pooledCubes = new List<GameObject>();
        for (int i = 0; i < amountOfCubes; i++)
        {
            Vector3 cubeLoc = cubeToPool.transform.position;
            cubeLoc.x = Random.Range(-10f, 10f);
            cubeLoc.y = 1.7f;
            cubeLoc.z = Random.Range(16f, 25f);
            GameObject obj = (GameObject)Instantiate(cubeToPool, cubeLoc, Quaternion.identity);

            pooledCubes.Add(obj);
           // Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);

        }

    }

    // Update is called once per frame
    void Update ()
    {
      

    }

}