using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeMovement : MonoBehaviour {

    public float cubeSpeed = 3.6f;
    private Rigidbody rb;

    //Executes once
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        StartCoroutine(SpeedUp());

    }

    //Executes every frame
    void Update()
    {
        rb.MovePosition(transform.position - (Vector3.forward * Time.smoothDeltaTime * cubeSpeed));
    }

   IEnumerator SpeedUp()
    {
        do
       {
          yield return new WaitForSeconds(2f);
          cubeSpeed = cubeSpeed + 0.1f;
          Debug.Log("force" + cubeSpeed.ToString());
       } while (cubeSpeed != 6.399997f);

    }

}
