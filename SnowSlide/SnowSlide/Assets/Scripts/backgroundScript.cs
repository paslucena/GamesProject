using UnityEngine;
using System.Collections;

public class backgroundScript : MonoBehaviour {

	public GameObject background1;
	public GameObject background2;
	public GameObject camera;
	bool canDraw = true;
	private int activeBG = 1;
	

	void Start () {
	}

	void FixedUpdate () {
		if (activeBG == 2) {
			if (background2.transform.localPosition.x <= -16.03f && canDraw == true) {
				canDraw = false;
				drawBG();
				
			}
		}else{
			if (background1.transform.localPosition.x <= -16.03f && canDraw == true) {
				canDraw = false;
				drawBG();
			}
		}


	}

	void drawBG(){

		float camPosY = camera.transform.position.y;
		
		if (activeBG == 1) {
			float newX = background1.transform.localPosition.x + 40.96f;
			background1.transform.localPosition = new Vector3 (newX, 0, 10);
			activeBG = 2;
		} else {
			float newX = background2.transform.localPosition.x + 40.96f;
			background2.transform.localPosition = new Vector3 (newX, 0, 10);
			activeBG = 1;
		}
		canDraw = true;
	}
}
