using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController character;
    public float speed;
    private int damage = 10;
    private int playerHealth = 100;
    public Text health;
    public Canvas gameOver;
    private bool playerAlive = true;
    public GameObject player;
    public AudioClip bulletTime;
    public AudioSource audioSource;

    void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = speed * Input.GetAxis("Horizontal");


        Vector3 movement = new Vector3(horizontal, 0, 0);

            character.SimpleMove(movement);

            health.text = "HEALTH: " + playerHealth;

      


        //bullet time
        if (Input.GetMouseButtonDown(1))
        {
            audioSource.mute = !audioSource.mute;
            AudioSource.PlayClipAtPoint(bulletTime, transform.position);
            Time.timeScale = 0.2f;
            Invoke("Bullet", 2f);
    
        }
     
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHealth = playerHealth - damage;

            if (playerHealth <= 0)
            {
 
                playerAlive = false;
                gameOver.gameObject.SetActive(true);
                damage = 0;
                player.gameObject.SetActive(false);
            }
        }
    }

    public void Bullet()
    {
        Time.timeScale = 1;
        audioSource.Play();
    }

}