using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamScript : MonoBehaviour {

	public GameManager gameManager;
	// GameManager型の変数gameManegerを定義しています。後にGameManager型のオブジェクトをアタッチする為、GameManager型で定義しています。
	public GUIStyle guiStyle;
	// GUIStyle型の変数guiStyleを定義しています。GUIStyle型の変数はpublicな変数として定義することで、詳細をInspectorビュー内で編集できます。

	void  OnGUI (){
		// UnityにおいてGUIは、 OnGUI関数の中に記述する必要があります。OnGUI内に記述した処理は毎フレーム呼び出されます。
		// GUI(グラフィカルユーザインタフェース)とは、クリックやタッチなどで操作可能な画面です。アイコンやメニューバーなど使い方がわかりやすい点が特徴です。Unityでは画面上に文字などを表す際にGUIを用いています。
		// Unityでは、GUIはOnGUI()の中に記述する必要があります。また、OnGUI()はUpdate関数が呼び出されるごとに動きます。

		Rect position1 = new Rect (10, 10, 200, 40);
		Rect position2 = new Rect (10, 50, 200, 40);
		Rect position3 = new Rect (10, 120, 200, 40);
		Rect position4 = new Rect (10, 160, 200, 40);
		// Rect: Rect関数は、x、y、幅、高さの4つの値によって定義される2次元の範囲です。GUI.Labelメソッドの引数として用いることで、文字を表示させる位置を設定することができます。
		// 書き方： new Rect(X座標, Y座標, 幅, 高さ);

		GUI.Label (position1, "スコア", guiStyle);
		GUI.Label (position2, gameManager.score.ToString(), guiStyle);
		GUI.Label (position3, "残機数", guiStyle);
		GUI.Label (position4, gameManager.life.ToString(), guiStyle);
		// ToString(): 対象のオブジェクトを文字列型(string型)に変更するメソッドです。
	}
}
