using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallController : MonoBehaviour
{
    Rigidbody2D ball;
    int player1Score = 0;
    int player2Score = 0;
    int roundCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        if (roundCount % 2 == 0) {
            ball.velocity = new Vector3(1f * 8f, ball.velocity.y, 0);
        } else {
            ball.velocity = new Vector3(-1f * 8f, ball.velocity.y, 0);
        }
    }
    public void changeP1Score(int amount) {
        player1Score += amount;
        resetAndPrintCurrentStatus();
    }
    public void changeP2Score(int amount) {
        player2Score += amount;
        resetAndPrintCurrentStatus();
    }
    void resetAndPrintCurrentStatus() {
        Debug.Log($"Player 1 score: {player1Score}, Player 2 score: {player2Score}");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
    }
}