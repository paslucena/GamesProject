using UnityEngine;
using System.Collections;

public class TerrainSpawner : MonoBehaviour {

	public GameObject firstTrack;
	public GameObject secondTrack;
	public GameObject thirdTrack;
	public GameObject fourthTrack;
	public GameObject fifthTrack;
	public GameObject sixthTrack;
	public GameObject seventhTrack;
	public GameObject eighthTrack;
	public GameObject ninethTrack;
	public GameObject tenthTrack;
	//public GameObject eleventhTrack;
	//public GameObject twelvethTrack;

	public float startSpawnPosition;

	public float spawnYPosition;

	int random;

	float block = 2.84f;
	float lastXPosition;
	float lastYPosition;

	GameObject camera;

	bool canSpawn = true;

	// Use this for initialization
	void Start () {
		lastXPosition = startSpawnPosition;
		lastYPosition = spawnYPosition;
		camera = GameObject.Find ("Main Camera");
		lastYPosition += block;
		Instantiate(firstTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
		lastXPosition+=8*block;
		lastYPosition-=3*block;
	}
	
	// Update is called once per frame 
	void Update () {

		if (camera.transform.position.x >= lastXPosition - (9 * block) && canSpawn == true) {
			canSpawn = false;
			random = Random.Range (1, 11);
			SpawnTerrain (random);

		}

	}
	

	void SpawnTerrain(int rand){

		float fixedX = 8 * block;
		float fixedY1 = 3 * block;
		float fixedY2 = 5*block;

		if (rand == 1) {
			lastYPosition+=block;
			Instantiate(firstTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 2) {
			lastYPosition+=block;
			Instantiate(secondTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 3) {
			
			lastYPosition+=block;
			Instantiate(thirdTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 4) {
			
			lastYPosition+=block;
			Instantiate(fourthTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 5) {
			
			lastYPosition+=block;
			Instantiate(fifthTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 6) {
			
			lastYPosition+=block;
			Instantiate(sixthTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 7) {
			
			lastYPosition+=block;
			Instantiate(seventhTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 8) {
			
			lastYPosition+=block;
			Instantiate(eighthTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY1;
		}
		if (rand == 9) {
			
			lastYPosition+=block;
			Instantiate(ninethTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY2;
		}
		if (rand == 10) {
			
			lastYPosition+=block;
			Instantiate(tenthTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX;
			lastYPosition-=fixedY2;
		}

		canSpawn = true;


		/*
		if (rand == 11) {

			lastXPosition+=2.74f;			//these additional measures were put here so
			lastYPosition+=block+ 3.473f;	// the tracks would be perfectly put together.
			Instantiate(eleventhTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX - 2.74f;		//same
			lastYPosition-=fixedY2 - 3.473f;	//here
		}
		if (rand == 12) {
				
			lastXPosition-=1.53f;			//these additional measures were put here so
			lastYPosition+=block+ 1.77f;	// the tracks would be perfectly put together.
			Instantiate(twelvethTrack, new Vector3(lastXPosition, lastYPosition, 0), Quaternion.Euler(0,0,0));
			lastXPosition+=fixedX + 1.53f;	//same	
			lastYPosition-=fixedY2 - 1.77f;	//here
		}*/
	}
}
