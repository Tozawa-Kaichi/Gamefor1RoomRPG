using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �u���b�N���̂��̂̋@�\���`����X�N���v�g
/// �X�y�����Ԉ���Ă���
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
                //�����X�^�[�g�n�_�������s������

                break;

        }
    }
    public MassScript(Vector2 adress,Status status)
    {

    }
}

