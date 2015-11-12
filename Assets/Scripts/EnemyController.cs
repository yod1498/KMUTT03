using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	Transform player;
	NavMeshAgent nav;
	
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (player.position);
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.SetActive(false);
		}
	}
}
