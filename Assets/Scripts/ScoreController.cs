using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public Text ScoreText;
	public GameObject buttonPanel;
	public Text winText;
	public static int score;
	public static int totalGold;
	public static int currentGold;

	// Use this for initialization
	void Start () {
		score = 0;
		currentGold = 0;
		GameObject[] golds = GameObject.FindGameObjectsWithTag ("Gold");
		totalGold = golds.Length;
	}
	
	// Update is called once per frame 
	void Update () {
		ScoreText.text = "Score : " + score.ToString ();

		if (currentGold >= totalGold) {
			winText.text = "YOU WIN !!!";
			buttonPanel.SetActive(true);
		}
	}

	public void Die (){
		winText.text = "YOU DIE !!!";
		buttonPanel.SetActive(true);
	}


	public void Restart(){
		Application.LoadLevel (0);
	}
}
