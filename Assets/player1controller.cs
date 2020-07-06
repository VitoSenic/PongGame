using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.up * Time.deltaTime * 10f, Space.World);
        }
        else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.down * Time.deltaTime * 10f, Space.World);
        }  
    }
}
