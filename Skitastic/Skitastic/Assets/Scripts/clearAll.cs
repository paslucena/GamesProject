using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clearAll : MonoBehaviour {

	public Text hs1;
	public Text hs2;
	public Text hs3;
	public Text hs4;
	public Text hs5;

	// Use this for initialization
	public void ClearAll () {
		PlayerPrefs.SetInt ("hs1", 0);
		PlayerPrefs.GetInt ("hs2", 0);
		PlayerPrefs.GetInt ("hs3", 0);
		PlayerPrefs.GetInt ("hs4", 0);
		PlayerPrefs.GetInt ("hs5", 0);

		hs1.text = "0";
		hs2.text = "0";
		hs3.text = "0";
		hs4.text = "0";
		hs5.text = "0";
	
	}

}
