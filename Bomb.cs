using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : EnemyController
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("collided with player");
        }
    }

    override public void Movement()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 1f);
    }
}
