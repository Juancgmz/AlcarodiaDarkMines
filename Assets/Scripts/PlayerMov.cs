using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public int playerHealth = 100;
    int damage = 10;
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public GameObject gameOverText, Player, blood;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Input del movimiento
        Vector2 moveImput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveImput.normalized * playerSpeed;
    }

    private void FixedUpdate()
    {
        //Ejecutar movimiento
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    //Función detección de colisión para daño al jugador
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            playerHealth -= damage;

            if(playerHealth <= 0)
            {
                playerHealth = 0;
                Player.SetActive(false);
                gameOverText.SetActive(true);
                Instantiate(blood, transform.position, Quaternion.identity);
            }
        }
    }
}