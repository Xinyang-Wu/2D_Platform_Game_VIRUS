using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{

	Rigidbody2D rb;
	//public GameObject gameobject;
	public float moveSpeed = 3;
	//Vector3 directionToTarget;
	public SpriteRenderer sr;
	



	// Use this for initialization
	void Start()
	{
		//target = GameObject.Find("player");
		rb = GetComponent<Rigidbody2D>();
		//moveSpeed = Random.Range(1f, 3f);
		sr = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{

		//directionToTarget = (target.transform.position - transform.position).normalized;
		rb.velocity = new Vector2(moveSpeed, transform.position.y);
	
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Vector2 characterScale = transform.localScale;

		if (collision.gameObject.tag == "Enemy")
		{
			//gameObject.transform
			//characterScale.x = -0.5f;
			if (sr.flipX == false)
			{
				sr.flipX = true;
				moveSpeed = -moveSpeed;
			}
			else
			{
				sr.flipX = false;
				moveSpeed = -moveSpeed;
			}
		}
	}
}




