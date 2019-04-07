using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;
    
	float speed = 1f;

	void Start ()
	{
        if (Stats.Difficulty == 1)
            speed = Random.Range(2f, 3f);
        else if (Stats.Difficulty == 2)
            speed = Random.Range(6f, 9f);
        else if (Stats.Difficulty == 3)
            speed = Random.Range(10f, 15f);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}
