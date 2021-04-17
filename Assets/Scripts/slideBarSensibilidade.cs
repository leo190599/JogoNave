using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slideBarSensibilidade : MonoBehaviour
{
    private Slider sl;
    private void Start()
    {
        sl = gameObject.GetComponent<Slider>();
    }
    public void alteraSensibilidade()
    {
        GameObject.Find("obj_Nave").GetComponent<Movimento_Nave>().alterarSensibilidade((int)(sl.value*50));
    }
    // Start is called before the first frame update
}
