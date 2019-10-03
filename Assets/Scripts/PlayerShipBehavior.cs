using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipBehavior : MonoBehaviour
{
	public float speed = 0.05f;
	public float boundary = 12.0f;
	public AudioClip shoot_sound1;
	public AudioClip shoot_sound2;
	public AudioSource audio;
	public Object laser_bullet;
	public Object asteroid;

	// Start is called before the first frame update
	void Start()
    {
		// Runs when the object is created
		audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		// Collect user input
		bool move_left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
		bool move_right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
		bool shoot_pressed = Input.GetKeyDown(KeyCode.Space);

		if (move_right && transform.position.x < boundary)
			transform.position += new Vector3(speed, 0, 0);
		if (move_left && transform.position.x > -boundary)
			transform.position += new Vector3(-speed, 0, 0);

		if(shoot_pressed)
		{
			Instantiate(laser_bullet, transform.position, Quaternion.identity);

			if(Random.Range(0, 100) > 50)
				audio.PlayOneShot(shoot_sound1, 2.0f);
			else
				audio.PlayOneShot(shoot_sound2, 2.0f);
		}

		if(Random.Range(0, 100) >= 94)
		{
			Instantiate(asteroid, new Vector3(Random.Range(-boundary, boundary), 12.0f, 0.0f), Quaternion.identity);
		}
	}
}
