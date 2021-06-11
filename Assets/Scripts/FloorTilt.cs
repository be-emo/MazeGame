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
		//�M������M�����Ƃ��ɁA���̃��b�Z�[�W�̏������s��
		serialHandler.OnDataReceived += OnDataReceived;
	}

	// Update is called once per frame
	void Update()
	{

	}

	/*
	 * �V���A�����󂯎�������̏���
	 */
	void OnDataReceived(string message)
	{
		try
		{
			// "x, y, z" �̂悤�ɘA�Ȃ��Ă���̂��J���}���Ƃɕ���
			string[] angles = message.Split(',');
			text.text = "x:" + angles[0] + "\n" + "y:" + angles[1] + "\n" + "z:" + angles[2] + "\n"; // �V���A���̒l���e�L�X�g�ɕ\��

			// ��]���̎w��
			// Vector3 axis_x = new Vector3(15f, 0f, 0f);

			// ��axis_x�̎����angles[1]������]������N�H�[�^�j�I��
			// Quaternion q_x = Quaternion.AngleAxis(-float.Parse(angles[1]), axis_x);

			// ��]���̎w��
			// Vector3 axis_z = new Vector3(0f, 0f, 1f);

			// ��axis_z�̎����angles[0]������]������N�H�[�^�j�I��
			// Quaternion q_z = Quaternion.AngleAxis(float.Parse(angles[0]), axis_z);

			// q_x�Cq_z������
			// Quaternion q = q_x * q_z;

			// ���������N�H�[�^�j�I���ŉ�]
			// this.transform.rotation = q * this.transform.rotation;
			// this.transform.rotation = (0f, 0f, 0f);

			// �N�H�[�^�j�I���ŉ�]������
			// stage.transform.rotation = Quaternion.Euler(q_x, 0, q_z);

			// Vector�͑O���珇�Ԃ�x,y,z�����ǁA���̂܂܃Z�b�g�����
			// Unity��̉�]�̌����ڂ��ςɂȂ�̂ŁAy,z�̒l�����ւ��Ă���B
			// float.Parse: ���l�̕�����`����P���x���������_���ɕϊ�
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