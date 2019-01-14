using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleScript : MonoBehaviour {

    public Rigidbody2D rb;

    public float rotateSpeed = 30f;

    public float shrinkSpeed = 2f;
	// Use this for initialization
	void Start () {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        transform.RotateAround(Vector3.zero, Vector3.forward, rotateSpeed * Time.deltaTime);
        if (transform.localScale.x <= 0.6f)
        {
            Spawner.instance.score++;
            Destroy(gameObject);
        }
	}
}
