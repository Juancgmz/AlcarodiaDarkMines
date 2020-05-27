using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BatMov : MonoBehaviour
{
    public Animator animator;
    private GameObject player;
    public Vector3 MyGameObjectPosition;
    // Update is called once per frame
    void Start()
    {
        MyGameObjectPosition = GameObject.Find("Bat").transform.position;
    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * 10, Input.GetAxis("Vertical") * 10, 0.0f);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
    }
}
