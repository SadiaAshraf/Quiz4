using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithInBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 14)
        {
            transform.Translate(Vector2.left);
        }
        else if (transform.position.x < -14)
        {
            transform.Translate(Vector2.right);
        }
    }
}
