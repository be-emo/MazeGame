using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �L�[�{�[�h�̑�����擾
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // �擾�����l�����Ƃ�X, Z�ɉ�����͂��쐬����
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Rigidbody�ɗ͂�������
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement);
    }
}
