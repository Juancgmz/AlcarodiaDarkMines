using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int playerHealth = 100;
    int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        print("Health: " + playerHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy")
        {
            print("Daño inflingido");
            playerHealth -= damage;
            print("Vida = " + playerHealth);
        }
    }
}
