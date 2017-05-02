using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnTriggerEnter (){
		Destroy(gameObject);
	}

	// Is Trigger: GameObjectにアタッチされているColliderのIs Triggerをオンにすると、衝突した際に跳ね返ったりするなどのような物理的な衝突動作を行わず、衝突判定のみを行うようになります。なので、物理的な衝突はさせたくないが、衝突したという情報のみを取得したい時などにチェックを入れます。
}
