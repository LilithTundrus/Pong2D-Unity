using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour {
    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;
    private GameObject ball;

    // Start is called before the first frame update
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball");
    }

    void Update() {
        Transform Ball;
        Transform Ai;
        Ball = GameObject.FindGameObjectWithTag("Ball").transform;
        Ai = this.transform;

        var pos = transform.position;
        var vel = rb2d.velocity;


        if (Ball.position.y > 0) {
            Debug.Log("Ball Pos " + Ball.position.y);
            Ai.position = new Vector3(Ai.position.x, Ball.position.y -0.6f, 0);
        }
        else if (Ball.position.y < 0) {
            Debug.Log("Ball Pos " + Ball.position.y);
            Ai.position = new Vector3(Ai.position.x, Ball.position.y -0.6f , 0);
        }

        if (pos.y > boundY) {
            pos.y = boundY;
        }
        else if (pos.y < -boundY) {
            pos.y = -boundY;
        }
        //transform.position = pos;
    }
}

