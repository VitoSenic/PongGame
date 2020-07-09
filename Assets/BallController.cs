using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallController : MonoBehaviour {
    Rigidbody2D ball;
    int player1Score = 0;
    int player2Score = 0;
    int roundCount = 0;
    public float maxSpeed = 30f;
    GameObject scoreboard;
    bool gamePause;
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start () {
        ball = GetComponent<Rigidbody2D> ();
        initialPosition = transform.position;
        scoreboard = GameObject.FindWithTag ("Score");
        scoreboard.SetActive (false);
        pushBall ();
    }
    void Update () {

        ball.velocity = Vector2.ClampMagnitude(ball.velocity, maxSpeed);

        if (Input.GetKeyDown ("space")) {
            if (!gamePause) return; {
                scoreboard.SetActive (false);
                pushBall ();
                Time.timeScale = 1f;
                gamePause = false;
            }
        }
    }
    void pushBall () {
        if (roundCount % 2 == 0) {
            ball.velocity = new Vector3 (1f * 8f, 0, 0);
        } else {
            ball.velocity = new Vector3 (-1f * 8f, 0, 0);
        }
    }
    public void changeP1Score (int amount) {
        player1Score += amount;
        resetAndPrintCurrentStatus ();
    }
    public void changeP2Score (int amount) {
        player2Score += amount;
        resetAndPrintCurrentStatus ();
    }
    void resetAndPrintCurrentStatus () {
        gamePause = true;
        roundCount++;
        player1controller p1 = GameObject.FindWithTag ("player1")
            .GetComponent<player1controller> ();
        player2controller p2 = GameObject.FindWithTag ("player2")
            .GetComponent<player2controller> ();
        p1.resetPos ();
        p2.resetPos ();
        transform.position = initialPosition;
        Time.timeScale = 0f;
        scoreboard.SetActive (true);
        GameObject.FindWithTag ("Score1")
            .GetComponent<UnityEngine.UI.Text> ().text = player1Score + "";
        GameObject.FindWithTag ("Score2")
            .GetComponent<UnityEngine.UI.Text> ().text = player2Score + "";
    }
}