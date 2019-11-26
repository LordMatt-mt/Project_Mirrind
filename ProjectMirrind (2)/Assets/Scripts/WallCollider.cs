using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WallCollider : MonoBehaviour {

    private int damage = 10;
    private int healths = 100;
    public Text health;
    public Canvas gameOver;
    private bool playerAlive = true;
    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        health.text = "HEALTH: " + healths;

      

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.transform.position = new Vector3(Random.Range(-10f, 10f), 1.7f, Random.Range(16f, 25f));
            healths = healths - damage;

            if (healths <= 0)
            {

                playerAlive = false;
                gameOver.gameObject.SetActive(true);
                damage = 0;
                player.gameObject.SetActive(false);
            }
        }
    }

}
