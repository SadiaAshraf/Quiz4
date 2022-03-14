using System.Collections;
using System.Collections.Generic;

using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HorizonalMove;
    public float VerticalMove;
    public Vector2 speed = new Vector2 (20,0);

    public TextMeshProUGUI LivesText;
    public TextMeshProUGUI TimeText;
   // public Bullet LiveScores;
    public int lives;
    public GameObject projectilePrefab;

    float  min;
    long  sec;
    void Start()
    {
        lives = 3;
       
        livesUpdate(0);


    }

    // Update is called once per frame
    void Update()
    { 
        //player movement
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector2.left);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector2.right);
        //}

        HorizonalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(speed.x * HorizonalMove, speed.y * VerticalMove);
        transform.Translate(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

       
    }

    void livesUpdate(int a)
    {
       
       LivesText.text = " Lives :" + lives;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyBomb"))
        {
            lives -= 1;
            Debug.Log("lives");
        }
    }
}
