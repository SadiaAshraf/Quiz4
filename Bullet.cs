using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public int score;
    //public EnemyController EnemyHealth;
    void Start()
    {
      //LiveScores = gameObject.GetComponent<Player>();

       // EnemyHealth = GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
           
        //}
        transform.Translate(Vector2.up * Time.deltaTime * 12);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
           
           
           Destroy(gameObject);
            if (collision.gameObject.CompareTag("EnemyBomb"))
             {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
            score += 10;
            Debug.Log("Scores = " + score);
        }

            //else if (collision.gameObject.CompareTag("Enemy"))
            //{
            //EnemyHealth.health -= 1;
            //}
    }
}
