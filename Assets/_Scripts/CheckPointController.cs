using UnityEngine;
using System.Collections;

public class CheckPointController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private Transform _transform;

	// PUBLIC INSTANCE VARIABLES (FOR TESTING)

	public GameObject SpawnPoint;


	// Use this for initialization
	void Start () {
		this._transform = GetComponent<Transform> ();
		this.SpawnPoint = GameObject.FindWithTag ("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			this.SpawnPoint.transform.position = this._transform.position;
		}
	}
}
