using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ランダムな要素からなにか動作するスクリプト用インターフェース
/// </summary>
public class I_Random : MonoBehaviour
{
    interface RandomPool
    {
        void RandomPool();
    }

}
