using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int speed = 6;
    public void Start()
    {
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();

        r2d.velocity = transform.up * speed;
    }

    // Update is called once per frame
    public void  OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
