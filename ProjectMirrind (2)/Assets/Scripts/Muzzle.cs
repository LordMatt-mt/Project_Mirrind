using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{
    public GameObject muzzleFlash; // drag the muzzle flash object here
 
    private bool muzzle = false; // muzzle flash enabled last frame?

    void Start()
    {
        // make sure the muzzle flash is initially disabled:
        muzzleFlash.GetComponent<Renderer>().enabled = false;
    }

    void TurnOnMuzzle()
    {
        // rotate the muzzle flash randomly about Z:
        muzzleFlash.transform.Rotate(0, 0, Random.Range(0, 90));
        muzzleFlash.GetComponent<Renderer>().enabled = true; // turn on muzzle flash
        muzzle = true; // tell the code to turn it off next frame
    }

    void TurnOffMuzzle()
    {
        if (muzzle)
        { // if muzzle flash enabled last frame...
            muzzleFlash.GetComponent<Renderer>().enabled = false; // turn it off
            muzzle = false;
        }
    }
}
