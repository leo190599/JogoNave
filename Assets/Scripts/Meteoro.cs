using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localScale = new Vector2(1,1)*Random.Range(0.5f,1.5f);
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -5);
    }

    // Update is called once per frame
}
