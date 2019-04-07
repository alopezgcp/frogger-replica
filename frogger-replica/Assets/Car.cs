using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	public float minSpeed = 2f;
	public float maxSpeed = 3f;

	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed * Stats.Difficulty, maxSpeed * Stats.Difficulty);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}
