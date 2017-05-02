using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardScript : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int hp = 2;

	void  OnCollisionEnter (){
		hp--;
		if (hp == 0){
			Destroy(gameObject);
			gameManager.score += 20;
		}
	}
}
