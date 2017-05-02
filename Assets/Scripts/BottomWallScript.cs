using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// スクリプトでシーンのロードについて扱う為には、using UnityEngine.SceneManagement;と記述する必要があります。

public class BottomWallScript : MonoBehaviour {

	public GameManager gameManager;
	public GameObject ballPrefab;
	Vector3 placePosition = new Vector3(0f, 0.6f, -7f);
	// Vector3型変数placePositionはBallオブジェクトを複製するPositionを指定するために定義します。今回は、複製するPositionを(X, Y, Z) = (0f, 0.6f, -7f)と指定しています。

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision){
		Destroy(collision.gameObject);

		if (gameManager.life > 0) {
			Instantiate (
				ballPrefab,
				placePosition,
				Quaternion.identity
			);
			// Instantiateは引数に既存のオブジェクトを指定することで、そのオブジェクトを複製します。また、引数にはオブジェクトの他に、複製する位置(Position)と回転(Rotation)を指定できます。今回のブロック崩しでは、BallがBottomWallに触れた時は、既存のBallが削除され、新たにスタート位置に新たなBallが複製されます。
			// 書き方： Instantiate (複製するオブジェクト, 複製する位置, 複製するオブジェクトの回転);

			//Quaternionは回転を4次元で表現します。Unityでは全ての回転を表現するのにQuaternionを用います。
			//Quaternion.identityは回転を親オブジェクトの回転座標と同じにします。親オブジェクトが存在していない場合はRotationを(x,y,z)= (0,0,0)に変更します。今回の場合は複製したBallオブジェクトのRotationを(x, y, z) = (0, 0, 0)にしています。 Quaternion関連は、4次元での表現になるため非常に難しいものです。現段階では、回転を表すものという認識で問題ありません。
			gameManager.life--;
		}
		else if (gameManager.life == 0){
			SceneManager.LoadScene("GameOver");
		}       
		// SceneManager.LoadSceneは引数に指定したシーンを呼び出します。今回の場合はSceneManager.LoadScene("GameOver")としているのでGameOverシーンが呼び出されます。
	}

	//OnCollisionEnterの引数が(Collision collision)となっています。OnCollisionEnterの引数では衝突してきたオブジェクトの情報を受け取ります。今回は、その受け取った情報をCollision型のcollisionという変数に代入をしています。今回はボールがぶつかってくるという想定なので、変数collisionにはボールオブジェクトの情報が入ります。
}
