using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
	public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
		Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
		transform.position += new Vector3(0, speed, 0);
    }

	void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(this.gameObject);
		Destroy(collision.gameObject);
	}
}
