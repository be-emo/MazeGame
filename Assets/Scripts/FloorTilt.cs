using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorTilt : MonoBehaviour
{

	public SerialHandler serialHandler;
	public Text text;
	public GameObject stage;

	// Use this for initialization
	void Start()
	{
		//信号を受信したときに、そのメッセージの処理を行う
		serialHandler.OnDataReceived += OnDataReceived;
	}

	// Update is called once per frame
	void Update()
	{

	}

	/*
	 * シリアルを受け取った時の処理
	 */
	void OnDataReceived(string message)
	{
		try
		{
			// "x, y, z" のように連なっているのをカンマごとに分割
			string[] angles = message.Split(',');
			text.text = "x:" + angles[0] + "\n" + "y:" + angles[1] + "\n" + "z:" + angles[2] + "\n"; // シリアルの値をテキストに表示

			// 回転軸の指定
			// Vector3 axis_x = new Vector3(15f, 0f, 0f);

			// 軸axis_xの周りにangles[1]だけ回転させるクォータニオン
			// Quaternion q_x = Quaternion.AngleAxis(-float.Parse(angles[1]), axis_x);

			// 回転軸の指定
			// Vector3 axis_z = new Vector3(0f, 0f, 1f);

			// 軸axis_zの周りにangles[0]だけ回転させるクォータニオン
			// Quaternion q_z = Quaternion.AngleAxis(float.Parse(angles[0]), axis_z);

			// q_x，q_zを合成
			// Quaternion q = q_x * q_z;

			// 合成したクォータニオンで回転
			// this.transform.rotation = q * this.transform.rotation;
			// this.transform.rotation = (0f, 0f, 0f);

			// クォータニオンで回転させる
			// stage.transform.rotation = Quaternion.Euler(q_x, 0, q_z);

			// Vectorは前から順番にx,y,zだけど、そのままセットすると
			// Unity上の回転の見た目が変になるので、y,zの値を入れ替えている。
			// float.Parse: 数値の文字列形式を単精度浮動小数点数に変換
			// float.Parse(angles[0]) * 45
			Vector3 angle = new Vector3(- float.Parse(angles[1]) * 45, 0, float.Parse(angles[0]) * 45);
			stage.transform.rotation = Quaternion.Euler(angle);
		}
		catch (System.Exception e)
		{
			Debug.LogWarning(e.Message);
		}
	}
}