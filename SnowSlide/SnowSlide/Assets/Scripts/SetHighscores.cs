using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetHighscores : MonoBehaviour {

	public Text hs1;
	public Text hs2;
	public Text hs3;
	public Text hs4;
	public Text hs5;


	// Use this for initialization
	void Start () {
		int one = PlayerPrefs.GetInt ("hs1");
		int two = PlayerPrefs.GetInt ("hs2");
		int three = PlayerPrefs.GetInt ("hs3");
		int four = PlayerPrefs.GetInt ("hs4");
		int five = PlayerPrefs.GetInt ("hs5");

		hs1.text = "" + one;
		hs2.text = "" + two;
		hs3.text = "" + three;
		hs4.text = "" + four;
		hs5.text = "" + five;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
