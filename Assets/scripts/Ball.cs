using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector3(speed * speedX, speed * speedY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        this.transform.position = Vector3.zero;

        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector3(speed * speedX, speed * speedY, 0);
    }

}
