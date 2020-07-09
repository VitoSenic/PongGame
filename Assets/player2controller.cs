using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2controller : MonoBehaviour {

    Vector3 initialPosition;
    Rigidbody2D rigitbody;
    // Start is called before the first frame update
    void Start () {
        initialPosition = transform.position;
        rigitbody = GetComponent<Rigidbody2D> ();
    }

    public void resetPos () {
        transform.position = initialPosition;
        rigitbody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.UpArrow)) {
            transform.Translate (Vector3.up * Time.deltaTime * 15f, Space.World);
        } else if (Input.GetKey (KeyCode.DownArrow)) {
            transform.Translate (Vector3.down * Time.deltaTime * 15f, Space.World);
        }
    }
    void OnCollisionExit2D (Collision2D other) {
        rigitbody.velocity = Vector3.zero;
    }
}