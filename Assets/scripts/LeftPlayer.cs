using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayer : MonoBehaviour
{

    Rigidbody2D rb;
    public float playerVelocity = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(0, vertical * playerVelocity);

    }
}
