using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	Transform player;
	NavMeshAgent nav;

	public float delayEnemy = 3;
	public bool isWalking = false;
	
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent> ();
	}

	void Start() {
		StartCoroutine(DelayEnemy());
	}
	
	IEnumerator DelayEnemy() {
		yield return new WaitForSeconds(delayEnemy);
		isWalking = true;
	}

	
	// Update is called once per frame
	void Update () {
		if (isWalking) {
			nav.SetDestination (player.position);
		} else {
			nav.SetDestination (gameObject.transform.position);
		}
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Player") {
			GameObject.Find("GameController").GetComponent<ScoreController>().Die();

			GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
			
			foreach (GameObject enemy in enemys) {
				enemy.SendMessage("PlayerDie");
			}

			col.gameObject.SetActive(false);
		}
	}

	public void PlayerDie(){
		isWalking = false;
	}
}
