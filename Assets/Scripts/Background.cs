using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    private float speed = 10.0f;
    private Vector2 initPosition;

	// Use this for initialization
	void Start () {
        initPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        if (transform.position.y <= (initPosition.y - 12.32f - 32.0f)) {
            transform.position = new Vector2(transform.position.x, initPosition.y);
        }
    }
}
