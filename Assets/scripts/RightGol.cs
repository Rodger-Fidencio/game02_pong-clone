using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGol : MonoBehaviour
{

    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("controller");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().countPoint(2);
    }
}
