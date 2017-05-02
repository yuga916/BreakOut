using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	float accel = 100.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (transform.right * Input.GetAxisRaw ("Horizontal") * accel, ForceMode.Impulse);
		// GetComponent<クラス>と記述することによって、指定したクラスのコンポーネントを取り出すことができます。今回の場合は、Playerに付与されているRigidbodyを取得しています。
		// AddForceはオブジェクトに対して力を加えるメソッドです。AddForceメソッドは、第1引数に力の大きさと方向を表すベクトルを、第2引数に力の加え方を取ります。今回の場合は、PlayerのRigidbodyに対し、transform.right方向にForceMode.Impulseという方法で力を加えています。
		// transform.right: X軸方向(右方)の単位ベクトル。AddForceの引数に指定することによって力を加える方向を指定できます。
		// Input.GetAxisRaw: Input.GetAxisRawは、入力されたキーを-1から1までの数値で返すことができます。今回は引数にHorizontalが指定されています。Horizontalに割り当てられているキーが入力された時-1から1までの数値で返すことになります。
		// Horizontalに割り当てられているキーを確認します。キーの割り当てはEdit -> Project Settings -> Inputから確認できます。 Horizontalには以下のように左右のキーが割り当てられています。そのため、今回の場合は、右のキーが押された場合に「1」を、左のキーが押された場合に「-1」を返しています。
		// ForceMode.Impulse: AddForceメソッドで指PlayerのRigidbodyに対し、右方向に(-1 or 1) ＊ 100 の力を加えていることになります。力の加え方はForceMode.Impulseとしています。 これによって対象オブジェクトであるPlayerが動くということです。AddForceメソッドで指定できる力の加え方。 ForceMode.Impulseは対象のオブジェクトの質量(Mass)を使用して、rigidbodyに瞬時に力を加えます。 オブジェクトの質量(Mass)によって挙動が変化します。これと似たものに、ForceMode.Forceというものがあります。ForceMode.Forceはオブジェクトに継続的に力を加えたい時に使用します。今回は頻繁に左右に動かすことを想定しているので、ふさわしくありません。
		// 上記のことを踏まえると、上記のコードはPlayerのRigidbodyに対し、右方向に(-1 or 1) ＊ 100 の力を加えていることになります。力の加え方はForceMode.Impulseとしています。 これによって対象オブジェクトであるPlayerが動くということです。

	}
}
