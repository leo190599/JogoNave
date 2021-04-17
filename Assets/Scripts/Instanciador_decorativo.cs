using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador_decorativo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject nuvem1;

    [SerializeField]
    private GameObject planeta;

    private float nuvemTimer = 0, planetaTimer = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        nuvemTimer += Time.deltaTime;
        planetaTimer += Time.deltaTime;
        if(nuvemTimer>=1)
        {
           Instantiate(nuvem1,new Vector3(Random.Range(-1.7f,1.7f),6,-3),Quaternion.identity);
            nuvemTimer = Random.value;
        }
        if(planetaTimer>=10 && GameObject.FindGameObjectsWithTag("planeta").Length==0)
        {
            Instantiate(planeta, new Vector3(Random.Range(-1.7f, 1.7f), 9, 4), Quaternion.identity);
            planetaTimer = Random.Range(0, 10);
        }
    }
}
