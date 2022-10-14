using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text healthDisplay;
    public float speed;
    private float input;

    Rigidbody2D rb;
    Animator anim;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        healthDisplay.text = health.ToString();
    }

    private void Update() {
        if (input < 0) {
            anim.SetBool("isRunningLeft", true);
            anim.SetBool("isRunningRight", false);
        } else if (input > 0) {
            anim.SetBool("isRunningRight", true);
            anim.SetBool("isRunningLeft", false);
        } else {
            anim.SetBool("isRunningRight", false);
            anim.SetBool("isRunningLeft", false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // player input
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
        //print(input);
    }

    public void TakeDamage(int damageAmount) {
        health -= damageAmount;
        healthDisplay.text = health.ToString();

        if(health <= 0) {
            Destroy(gameObject);
        }
    }
}
