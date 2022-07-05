using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI上の部屋の表示や押された時の動作を管理するスクリプト
/// </summary>
public class RandomRoomController : MonoBehaviour , I_Random
{
    [Tooltip("ランダムに選ばれる部屋効果の一覧")]
    [SerializeField] List<Texture2D> _roomEffectIcons;

    [SerializeField] int _percentOfZeroIndex = 10;
    public void RandomPool()
    {
        
    }
    Texture2D RandomSelected()
    {
        int random = Random.Range(0, 100);
        if (random < _percentOfZeroIndex)
        {
            return _roomEffectIcons[0];
        }
        return _roomEffectIcons[0];
    }

    private void Start()
    {
        
    }

}
