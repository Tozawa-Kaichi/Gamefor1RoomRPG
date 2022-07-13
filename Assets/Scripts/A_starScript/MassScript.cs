using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ブロックそのものの機能を定義するスクリプト
/// スペルが間違っている
/// </summary>
public class MassScript : MonoBehaviour
{

    private Vector2 adress;
    [SerializeField] private Status status;
    private void Start()
    {
        adress = this.transform.position;
        switch (this.status)
        {
            case Status.StartPosition:
                //もしスタート地点だっらら行う処理

                break;

        }
    }
    public MassScript(Vector2 adress,Status status)
    {

    }
}

