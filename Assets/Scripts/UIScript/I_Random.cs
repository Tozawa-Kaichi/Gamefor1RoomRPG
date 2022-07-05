using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ランダムな要素からなにか動作するスクリプト用インターフェース
/// </summary>
interface I_Random 
{
    void RandomPool();
    //敵や部屋効果はランダムなプールの中から選ばれるべきである
}
