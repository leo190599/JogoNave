using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 5);
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag=="meteoro")
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
}
