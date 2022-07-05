using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// UI��̕����̕\���≟���ꂽ���̓�����Ǘ�����X�N���v�g
/// </summary>
public class RandomRoomController : MonoBehaviour , I_Random
{
    [Tooltip("�����_���ɑI�΂�镔�����ʂ̈ꗗ ��0�Ԗڂ̃C���f�b�N�X��Non�ɂ��Ă�������")]
    [SerializeField] List<Texture2D> _roomEffectIcons;
    [Tooltip("�����_���ɑI�΂�镔���C�x���g�̈ꗗ ��0�Ԗڂ̃C���f�b�N�X��Non�ɂ��Ă�������")]
    [SerializeField] List<Texture2D> _roomEventIcons;

    [SerializeField] int _percentOfZeroIndex = 10;
    public void RandomPool()
    {
        
    }
    Texture2D RandomEffectSelected()//�����_���ȕ������ʂ̑I�o
    {
        int random = Random.Range(0, _roomEffectIcons.Count);
        return _roomEffectIcons[random];
    }
    Texture2D RandomEventSelected()//�����_���ȕ����C�x���g�̑I�o
    {
        int random = Random.Range(0, _roomEventIcons.Count);
        return _roomEventIcons[random];
    }

    private void Start()
    {
        
    }

}
