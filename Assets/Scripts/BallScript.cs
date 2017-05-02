using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	float speed = 15.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump") && GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0)){
			GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
		}
		// 条件1: JUMPに割り振られているキー(spaceキー)が離された瞬間
		// 条件2: Ballの速度オブジェクトが(X, Y, Z) = (0, 0, 0)のとき、つまり静止している時,上記の2つの条件がtrueを返す時、10行目の処理が行われます。
		// GetButtonUp: GetButtonUpは押しているキーを離した瞬間にtrueを返します。今回の場合は、spaceキーを離した瞬間にtrueを返しています。GetButtonUpと似たもので、GetButtonとGetButtonDownがあります。それぞれどのタイミングでtrueを返すのか比較します。
		// Vector3: Unityでは、オブジェクトの位置や速度をVector3を用いて表現します。Vector3ではX, Y, Zの3方向におけるベクトルの大きさ(速度)や位置、回転を指定できます。
		// velocity: Unityにおいて速さはベクトルを用いて表します。ベクトルが大きければ速くなり、小さければ、遅くなります。また、ベクトルの方向によって、移動する方向が決まります。
		// ForceMode.VelocityChange: AddForceメソッドで指定できる力の加え方。 ForceMode.VelocityChangeは対象のオブジェクトの質量(Mass)を無視して、rigidbodyに瞬時に力を加えます。 オブジェクトの質量(Mass)は挙動に影響を与えません。
	}

	void OnCollisionEnter (){
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		// BallにアタッチされているRigidbodyコンポーネントを取得しています。
		rigidbody.velocity = rigidbody.velocity.normalized * 15;
		// 取得したRigidbodyの速度ベクトルvelocityに対し、正規化を行っています。これにより、Ballの角度を変えず、大きさを１にしています。さらに、正規化した速度ベクトルに対し15を掛けています。よって、Ballの速度ベクトルは(X, Y, Z) = (15/√2, 0, 15/√2)となります。これによりBallの速度を一定に保っています。
		// normalized: normalizedはベクトルの大きさを正規化するものです。正規化することによって、角度はそのままでベクトルの大きさが1となります。今回の場合は速度ベクトルであるrigidbody.velocityに対して正規化を行っています。これによりBallの速度ベクトルは(x, y, z) = (1/√2, 0, 1/√2)となります。(yはFreeze Positionをかけているため、値は0です。)
	}



}
