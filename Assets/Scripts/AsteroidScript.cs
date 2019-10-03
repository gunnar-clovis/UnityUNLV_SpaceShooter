using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
	public float speed = 0.1f;
	public Sprite asteroid1;
	public Sprite asteroid2;
	public Sprite asteroid3;
	public Sprite asteroid4;
	public Sprite asteroid5;
	public Sprite asteroid6;
	public Sprite asteroid7;
	public Sprite asteroid8;

	// Start is called before the first frame update
	void Start()
    {
		int rand = Random.Range(1, 8 + 1);
		var spr = GetComponent<SpriteRenderer>();

		switch(rand)
		{
			case 1:
				spr.sprite = asteroid1;
				break;
			case 2:
				spr.sprite = asteroid2;
				break;
			case 3:
				spr.sprite = asteroid3;
				break;
			case 4:
				spr.sprite = asteroid4;
				break;
			case 5:
				spr.sprite = asteroid5;
				break;
			case 6:
				spr.sprite = asteroid6;
				break;
			case 7:
				spr.sprite = asteroid7;
				break;
			case 8:
				spr.sprite = asteroid8;
				break;
		}

		Destroy(this.gameObject, 7.0f);
	}

    // Update is called once per frame
    void Update()
    {
		transform.position += new Vector3(0, -speed, 0);
    }

	void OnCollisionEnter2D(Collision2D collision)
	{

	}
}
