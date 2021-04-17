using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enfeites : MonoBehaviour
{
    [SerializeField]
    private float finalY = -6;
    [SerializeField]
    private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector2(0,-speed));
        if(transform.position.y<finalY)
        {
            Destroy(gameObject);
        }
    }
}
