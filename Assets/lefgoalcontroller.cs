using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefgoalcontroller : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
    void OnTriggerEnter2D (Collider2D col) {
        BallController controller = col.gameObject.gameObject.GetComponent<BallController> ();
        if (controller != null) {
            controller.changeP1Score(1);
        }
    }
}