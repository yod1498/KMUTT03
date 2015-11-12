using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	NavMeshAgent navigationAgent;
	Animator animator;

	// Use this for initialization
	void Start () {
		navigationAgent = GetComponent<NavMeshAgent> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();

		if (animator) {
			float v = navigationAgent.velocity.x;
			if (v != 0){
				animator.SetBool("Moving",true);
			}else{
				animator.SetBool("Moving",false);
			}
		}
	}

	void PlayerMove (){
		if (Input.GetMouseButtonUp (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit, 500)){
				navigationAgent.SetDestination(hit.point);
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Gold") {
			GetComponent<AudioSource>().Play();
		}
	}
}
