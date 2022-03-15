using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;

    public Rigidbody2D rb2D;
    public float velocity = 1f;
    public GameManager managerGame;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //zıplatma
            rb2D.velocity = Vector2.up * velocity;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
     
       
        {
            if(collision.gameObject.name== "ScoreArea")
             {
             managerGame.UpdateScore();
             }
        }
}
