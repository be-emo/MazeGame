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
		serialHandler.OnDataReceived += OnDataReceived;
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnDataReceived(string message)
	{
		try
		{
			string[] angles = message.Split(',');
			text.text = "x:" + angles[0] + "\n" + "y:" + angles[1] + "\n" + "z:" + angles[2] + "\n";

			Vector3 angle = new Vector3(- float.Parse(angles[1]) * 45, 0, float.Parse(angles[0]) * 45);
			stage.transform.rotation = Quaternion.Euler(angle);
		}
		catch (System.Exception e)
		{
			Debug.LogWarning(e.Message);
		}
	}
}