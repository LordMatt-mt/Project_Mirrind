using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {
    public Transform firePoint;
    float FireRate  = 0.2f;
    private float Fire;
    public ParticleSystem ps;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > Fire)
        {
       
            Fire = Time.time + FireRate;

            ps.Emit(ps.emission.burstCount);
            
        }
    }
}
