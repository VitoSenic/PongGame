using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefgoalcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Colider2D col) {
        BallController ballTemp = GetComponent<GetComponent>();
        if (ballTemp != null) {
        ballTemp.changeP1Score(1);
        }
    }
}
