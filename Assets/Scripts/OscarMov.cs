﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using static Player;

public class OscarMov : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal")*Player.speed, Input.GetAxis("Vertical")*Player.speed, 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        
        transform.position = transform.position + movement * Time.deltaTime;
    }
}
