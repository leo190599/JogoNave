using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiros : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    private float timer=0;
    public GameObject[] c;
    private int nextGun = 0;
    // Start is called before the first frame update
    private void Start()
    {
        c = new GameObject[2];
        c[0] = transform.Find("c1").gameObject;
        c[1] = transform.Find("c2").gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
        if(timer>=.30f)
        {
            
              GameObject bull = Instantiate(bullet, c[nextGun].transform.position,Quaternion.identity);
                if(nextGun==1)
                 {
                    nextGun = 0;
                }
                else
                {
                    nextGun = 1;
                }
              Destroy(bull, 2);
            timer = 0;
        }
    }
}
