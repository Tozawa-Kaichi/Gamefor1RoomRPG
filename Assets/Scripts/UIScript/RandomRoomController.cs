using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI��̕����̕\���≟���ꂽ���̓�����Ǘ�����X�N���v�g
/// </summary>
public class RandomRoomController : MonoBehaviour , I_Random
{
    [Tooltip("�����_���ɑI�΂�镔�����ʂ̈ꗗ")]
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
