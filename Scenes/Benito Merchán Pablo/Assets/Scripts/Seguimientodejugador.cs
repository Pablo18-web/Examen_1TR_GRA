using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Seguimientodejugador : MonoBehaviour {
	
	[SerializeField] Transform playerPosition;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y + 40, playerPosition.position.z - 10);
	}
}
