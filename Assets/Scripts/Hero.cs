using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
    public float speed;
    public float width;
    public ControlButton leftButton;
    public ControlButton rightButton;
    public Vector2 dest = Vector2.zero;

	// Use this for initialization
	void Start () {
        dest = transform.position;
        width = GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    private void Update() {
    }

    private void FixedUpdate() {
        if (leftButton.isPressed()) {
            Vector2 d = (Vector2)transform.position + new Vector2(-1*speed, 0);
            if (d.x >= (-10+ width/2)) {
                dest = d;
            }
            Debug.Log(dest);
        }
        if (rightButton.isPressed()) {
            Vector2 d = (Vector2)transform.position + new Vector2(1 * speed, 0);
            if (d.x <= (10- width/2)) {
                dest = d;
            }
            Debug.Log(dest);
        }

        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        Vector2 dir = dest - (Vector2)transform.position;
    }
}
