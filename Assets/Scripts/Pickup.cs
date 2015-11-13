using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	public GameObject MyPrefab;
	GameObject myPrefab;


	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			ScoreController.score += 10;
			ScoreController.totalGold --;
			myPrefab = Instantiate(MyPrefab, this.transform.position, MyPrefab.transform.rotation) as GameObject;
			gameObject.SetActive(false);
		}
	}
}
