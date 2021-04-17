using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    [SerializeField]
    private GameObject meteoro;
    private float timer=0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=.25f)
        {
            GameObject met= Instantiate(meteoro,new Vector2(Random.Range(-1.7f,1.7f),6),Quaternion.identity);
            Destroy(met,4);
            timer = 0;
        }
    }
}
