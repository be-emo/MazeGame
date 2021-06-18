using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOnFloor : MonoBehaviour
{
    public SerialHandler serialHandler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // ボールと各フロアの衝突の瞬間の判定を行う
    /*
    void OnCollisionEnter(Collision other) {
        Debug.Log("enter");
        switch(other.gameObject.name) {
            case "Floor_1":
                serialHandler.Write("1");
                break;
            case "Floor_2":
                serialHandler.Write("2");
                break;
            case "Floor_3":
                serialHandler.Write("3");
                break;
            case "Floor_4":
                serialHandler.Write("4");
                break;
            case "Floor_5":
                serialHandler.Write("5");
                break;
            case "Floor_6":
                serialHandler.Write("6");
                break;
            case "Floor_7":
                serialHandler.Write("7");
                break;
            case "Floor_8":
                serialHandler.Write("8");
                break;
            case "Floor_9":
                serialHandler.Write("9");
                break;
            case "Floor_10":
                serialHandler.Write("a");
                break;
            case "Floor_11":
                serialHandler.Write("b");
                break;
            case "Floor_12":
                serialHandler.Write("c");
                break;
            case "Floor_13":
                serialHandler.Write("d");
                break;
            case "Floor_14":
                serialHandler.Write("e");
                break;
            case "Floor_15":
                serialHandler.Write("f");
                break;
            case "Floor_16":
                serialHandler.Write("g");
                break;
            case "Floor_17":
                serialHandler.Write("h");
                break;
            case "Floor_18":
                serialHandler.Write("i");
                break;
            case "Floor_19":
                serialHandler.Write("j");
                break;
            case "Floor_20":
                serialHandler.Write("k");
                break;
            default:
                Debug.Log("接触していません");
                break;
        }
        serialHandler.Write(",");
    }
    */

    // ボールと各フロアの衝突中の判定を行う
    void OnCollisionStay(Collision other) {
        switch (other.gameObject.name)
        {
            case "Floor_1":
                serialHandler.Write("1");
                Debug.Log("1");
                break;
            case "Floor_2":
                serialHandler.Write("2");
                break;
                Debug.Log("2");
            case "Floor_3":
                serialHandler.Write("3");
                Debug.Log("3");
                break;
            case "Floor_4":
                serialHandler.Write("4");
                Debug.Log("4");
                break;
            case "Floor_5":
                serialHandler.Write("5");
                Debug.Log("5");
                break;
            case "Floor_6":
                serialHandler.Write("6");
                Debug.Log("6");
                break;
            case "Floor_7":
                serialHandler.Write("7");
                Debug.Log("7");
                break;
            case "Floor_8":
                serialHandler.Write("8");
                Debug.Log("8");
                break;
            case "Floor_9":
                serialHandler.Write("9");
                Debug.Log("9");
                break;
            case "Floor_10":
                serialHandler.Write("a");
                Debug.Log("10");
                break;
            case "Floor_11":
                serialHandler.Write("b");
                Debug.Log("11");
                break;
            case "Floor_12":
                serialHandler.Write("c");
                Debug.Log("12");
                break;
            case "Floor_13":
                serialHandler.Write("d");
                Debug.Log("13");
                break;
            case "Floor_14":
                serialHandler.Write("e");
                Debug.Log("14");
                break;
            case "Floor_15":
                serialHandler.Write("f");
                Debug.Log("15");
                break;
            case "Floor_16":
                serialHandler.Write("g");
                Debug.Log("16");
                break;
            case "Floor_17":
                serialHandler.Write("h");
                Debug.Log("17");
                break;
            case "Floor_18":
                serialHandler.Write("i");
                Debug.Log("18");
                break;
            case "Floor_19":
                serialHandler.Write("j");
                Debug.Log("19");
                break;
            case "Floor_20":
                serialHandler.Write("k");
                Debug.Log("20");
                break;
            default:
                Debug.Log("接触していません");
                break;
        }
        serialHandler.Write(",");
    }

    // ボールと各フロアの衝突の離脱の判定を行う
    // 衝突がなくなるときには，文字列"x"をシリアル通信で送信し，振動を終了させる
    void OnCollisionExit(Collision other) {
        Debug.Log("exit");
        switch (other.gameObject.name)
        {
            case "Floor_1":
                serialHandler.Write("x");
                break;
            case "Floor_2":
                serialHandler.Write("x");
                break;
            case "Floor_3":
                serialHandler.Write("x");
                break;
            case "Floor_4":
                serialHandler.Write("x");
                break;
            case "Floor_5":
                serialHandler.Write("x");
                break;
            case "Floor_6":
                serialHandler.Write("x");
                break;
            case "Floor_7":
                serialHandler.Write("x");
                break;
            case "Floor_8":
                serialHandler.Write("x");
                break;
            case "Floor_9":
                serialHandler.Write("x");
                break;
            case "Floor_10":
                serialHandler.Write("x");
                break;
            case "Floor_11":
                serialHandler.Write("x");
                break;
            case "Floor_12":
                serialHandler.Write("x");
                break;
            case "Floor_13":
                serialHandler.Write("x");
                break;
            case "Floor_14":
                serialHandler.Write("x");
                break;
            case "Floor_15":
                serialHandler.Write("x");
                break;
            case "Floor_16":
                serialHandler.Write("x");
                break;
            case "Floor_17":
                serialHandler.Write("x");
                break;
            case "Floor_18":
                serialHandler.Write("x");
                break;
            case "Floor_19":
                serialHandler.Write("x");
                break;
            case "Floor_20":
                serialHandler.Write("x");
                break;
        }
    }
}
