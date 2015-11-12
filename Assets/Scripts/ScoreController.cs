using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text ScoreText;
	static public int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "Score : " + score.ToString ();
	}
}
