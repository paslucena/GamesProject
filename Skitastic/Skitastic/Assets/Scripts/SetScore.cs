using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetScore : MonoBehaviour {

	public Text score;
	// Use this for initialization
	void Start () {
		int s = PlayerPrefs.GetInt ("score");

		int one = PlayerPrefs.GetInt ("hs1");
		int two = PlayerPrefs.GetInt ("hs2");
		int three = PlayerPrefs.GetInt ("hs3");
		int four = PlayerPrefs.GetInt ("hs4");
		int five = PlayerPrefs.GetInt ("hs5");

		score.text = "Your Score: " + s;

		if (s > one) {
			PlayerPrefs.SetInt("hs5", four);
			PlayerPrefs.SetInt("hs4", three);
			PlayerPrefs.SetInt("hs3", two);
			PlayerPrefs.SetInt("hs2", one);
			PlayerPrefs.SetInt("hs1", s);
		}else if(s > two){
			PlayerPrefs.SetInt("hs5", four);
			PlayerPrefs.SetInt("hs4", three);
			PlayerPrefs.SetInt("hs3", two);
			PlayerPrefs.SetInt("hs2", s);
		}else if(s > three){
			PlayerPrefs.SetInt("hs5", four);
			PlayerPrefs.SetInt("hs4", three);
			PlayerPrefs.SetInt("hs3", s);
		}else if(s > four){
			PlayerPrefs.SetInt("hs5", four);
			PlayerPrefs.SetInt("hs4", s);
		}else if(s > five){
			PlayerPrefs.SetInt("hs5", s);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
