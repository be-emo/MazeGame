using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SerialText : MonoBehaviour
{

	public SerialHandler serialHandler;
	public Text text;

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
			text.text = message;
		}
		catch (System.Exception e)
		{
			Debug.LogWarning(e.Message);
		}
	}
}