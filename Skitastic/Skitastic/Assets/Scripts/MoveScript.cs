using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	
	public float speed = 10;
	public int jumpSpeed;
	//public int gravity;
	public float jumpHeight;
	public float multiplier;
	public float Position;
	public bool isJumping = false;
	public Rigidbody2D rb;
	public Animation endAnimation;
	// Use this for initialization
	void Start () {;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = speed * new Vector3 (1f, 0f, 0f);
		//rigidbody2D.AddForce (new Vector3 (0, -gravity));
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			if (isJumping == false) {
				rigidbody2D.AddForce (Vector3.up * jumpHeight * multiplier);
				isJumping = true;
			}
			
		}

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(Position > -20)
		{
			isJumping = false;
		}
		//if (speed < 5) {
		//	isJumping = true;
		//}
		if (col.gameObject.tag == "Rock") {
					speed = 0;
					Application.LoadLevel(2);
				}
	}
	
}
