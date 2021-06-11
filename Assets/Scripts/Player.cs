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
        // キーボードの操作を取得
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 取得した値をもとにX, Zに加える力を作成する
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Rigidbodyに力を加える
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement);
    }
}
