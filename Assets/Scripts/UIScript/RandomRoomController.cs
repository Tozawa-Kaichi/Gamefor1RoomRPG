using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI上の部屋の表示や押された時の動作を管理するスクリプト
/// </summary>
public class RandomRoomController : MonoBehaviour , I_Random
{
    [Tooltip("ランダムに選ばれる部屋効果の一覧 ※0番目のインデックスはNonにしてください")]
    [SerializeField] List<Texture2D> _roomEffectIcons;
    [Tooltip("ランダムに選ばれる部屋イベントの一覧 ※0番目のインデックスはNonにしてください")]
    [SerializeField] List<Texture2D> _roomEventIcons;

    [SerializeField] int _percentOfZeroIndex = 10;
    public void RandomPool()
    {
        
    }
    Texture2D RandomEffectSelected()//ランダムな部屋効果の選出
    {
        int random = Random.Range(0, _roomEffectIcons.Count);
        return _roomEffectIcons[random];
    }
    Texture2D RandomEventSelected()//ランダムな部屋イベントの選出
    {
        int random = Random.Range(0, _roomEventIcons.Count);
        return _roomEventIcons[random];
    }

    private void Start()
    {
        
    }

}
