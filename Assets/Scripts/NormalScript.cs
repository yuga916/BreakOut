using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScript : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnCollisionEnter (){
		Destroy(gameObject);
		gameManager.score += 10;
	}

	//OnCollisionEnter(): OnCollisionEnter内で定義された処理は、そのスクリプトがアタッチされているオブジェクトが他のオブジェクトに衝突した際に呼び出されます。今回の場合は、BallがNormalBlockに衝突した際にOnCollisionEnter内に定義されている「Destroy(gameObject);」が呼び出されます。Destroyの引数に指定したgameObjectとは、そのスクリプトがアタッチされているGameObjectそのものを指します。
}


