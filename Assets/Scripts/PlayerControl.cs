using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject Bala;
    private void Update()
    {
        transform.Translate((Input.GetAxis("Vertical") * transform.up * 0.05f) + (Input.GetAxis("Horizontal") * transform.right * 0.05f));
        if (Input.GetKeyDown("space") || Input.GetMouseButtonUp(0))
        {
            Instantiate(Bala, transform.position, Quaternion.identity);
        }
    }
}
