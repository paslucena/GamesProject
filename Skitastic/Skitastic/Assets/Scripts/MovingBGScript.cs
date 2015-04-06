using UnityEngine;
using System.Collections;

public class MovingBGScript : MonoBehaviour {

	private GameObject camera;
	private float speed;


	// Use this for initialization
	void Start () {
		camera = GameObject.Find ("Main Camera");
		speed = -0.01f;
	}
	
	// Update is called once per frame
	void Update () {

		float x = transform.position.x + speed;
		float y = camera.transform.position.y;
		transform.position = new Vector3 (x, y, 0);

	}


}
