using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0.1f;
    public int health = 3;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //  Vector2 EnemyMov = new Vector2(Random.Range(-11,11), Random.Range(5,0));

        Movement();
        if (health < 0)
        {
            Destroy(gameObject);
        }

        bounds();
    }




    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bomb"))
        {
            health = health - 1;

        } //player bullet
       

        //Destroy(gameObject);
        Debug.Log("collision 2d");
    }

    virtual  public void Movement()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bomb"))
        {
            health = health - 1;
            Debug.Log("collision hogai");
        } //player bullet

    }

    public void bounds()
    {
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
      
    }
}

