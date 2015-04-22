using UnityEngine;
using System.Collections;

public class CameraController: MonoBehaviour {
	
	float ydir = 0f;
	public GameObject player;
	private Vector3 offset;
	public float enterX;
	public float enterY;
	//for our GUIText object and our score
	public GUIElement gui;
	int playerScore = 0;
	

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		float x = player.transform.position.x + enterX;
		float y = player.transform.position.y + enterY;
		transform.position = new Vector3 (x, y, 0) + offset;
		playerScore = (int)player.transform.position.x;
		PlayerPrefs.SetInt ("score", playerScore);
	}


}