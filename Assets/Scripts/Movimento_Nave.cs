using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimento_Nave : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 previowsM, currentM, nextMove, parcialMove;
    [SerializeField]
    private int sensibility;
    private
    void Start()
    {
        if (sensibility == 0)
        {
            sensibility = 1;
        }
        rb = gameObject.GetComponent<Rigidbody2D>();
        parcialMove = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            previowsM.x = Input.mousePosition.x;
            previowsM.y = Input.mousePosition.y;
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            currentM.x = Input.mousePosition.x;
            currentM.y = Input.mousePosition.y;

            nextMove.x = (currentM.x - previowsM.x) / sensibility;
            nextMove.y = (currentM.y - previowsM.y) / sensibility;

            parcialMove += nextMove;

            previowsM.x = currentM.x;
            previowsM.y = currentM.y;
        }
    }

    private void FixedUpdate()
    {
        if (parcialMove.x < -1.7f)
        {
            parcialMove.x = -1.7f;
        }
        else if (parcialMove.x > 1.7f)
        {
            parcialMove.x = 1.7f;
        }
        if (parcialMove.y < -4.4)
        {
            parcialMove.y = -4.4f;
        }
        else if (parcialMove.y > 4.3)
        {
            parcialMove.y = 4.3f;
        }
        rb.MovePosition(parcialMove);
    }

    public void unPause()
    {
        nextMove = new Vector2(0,0);
        parcialMove = transform.position;
    }

    public void alterarSensibilidade (int sensibilidade)
    {
        sensibility = 100 - sensibilidade;
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag=="meteoro")
        {
            gameObject.GetComponent<SalvarPontuacao>().salvarPontos( GameObject.Find("Canvas").transform.Find("pointCounter").GetComponent<PointCounter>().getPontos());
            SceneManager.LoadScene("MainMenu");
        }
    }
}
