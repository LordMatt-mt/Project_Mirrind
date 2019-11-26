using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour
{
    public AudioClip gunShot;
    public float fireRate;
    [Range(0.1f, 1.5f)]
    public float range;
    public Transform firePoint;
    public Text scoreTxt;
    public Text scoreTxt2;
    private int score = 0;
    public Text highScore;
    // Use this for initialization
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Best Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (score > PlayerPrefs.GetInt("Best Score", 0))
        {
            PlayerPrefs.SetInt("Best Score", score);
            highScore.text = score.ToString();

        }

        if (Input.GetMouseButtonDown(0))
        {
            Firegun();
            AudioSource.PlayClipAtPoint(gunShot, transform.position);

        }

    }

    public void Firegun()
    {

        RaycastHit hitInfo;

        if(Physics.Raycast(firePoint.position, firePoint.forward, out hitInfo, 100))
        {
           
            Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.green, 2f);
            if(hitInfo.transform.tag == "Enemy")
            {
                print("hit");
                
                hitInfo.collider.gameObject.transform.position = new Vector3(Random.Range(-10f, 10f), 1.7f, Random.Range(16f, 25f));
                score += 1;
                scoreTxt.text = "SCORE: " + score;
                scoreTxt2.text = "Score: " + score;
            }
         
        }

    }
}
