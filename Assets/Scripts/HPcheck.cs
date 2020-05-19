using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPcheck : MonoBehaviour
{
    public int HP = 10;
    // Start is called before the first frame update
    public GameObject GameOverText, RestartButton, MainMenuButton, Head, Body, Shadow, blood;
    private void Start()
    {
        GameOverText.SetActive(false);
        RestartButton.SetActive(false);
        MainMenuButton.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            HP = HP - 10;
            if (HP <= 0)
            {
                HP = 0;
                GameOverText.SetActive(true);
                RestartButton.SetActive(true);
                MainMenuButton.SetActive(true);

                Head.SetActive(false);
                Body.SetActive(false);
                Shadow.SetActive(false);

                Instantiate(blood, transform.position, Quaternion.identity);
            }
        }
    }
}
