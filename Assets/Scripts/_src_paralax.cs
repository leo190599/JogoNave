using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _src_paralax : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    public float startY = 10f;
    public float finalY = -10f;
    private void Start()
    {
        speed *= -1;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(new Vector2(0f,speed));
        if(transform.position.y<=finalY)
        {
            transform.position = new Vector3(0,startY,transform.position.z);
        }
    }
}
