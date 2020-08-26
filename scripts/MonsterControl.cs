using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour {

	Rigidbody2D rb;
	GameObject target;
	public float moveSpeed;
	Vector3 directionToTarget;


	// Use this for initialization
	void Start () {
		target = GameObject.Find ("player");
		rb = GetComponent<Rigidbody2D> ();
		moveSpeed = Random.Range (1f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null)
		{
			directionToTarget = (target.transform.position - transform.position).normalized;
			rb.velocity = new Vector2(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed);
		}
		else
			rb.velocity = Vector3.zero;
	}


}
