using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �񎟊֐��ƘA���������ŋȐ����v�Z����X�N���v�g
/// </summary>
public class CurveCalculation : MonoBehaviour
{
    [SerializeField] Vector2 _firstPoint;//�Ȑ��̊J�n�n�_
    [SerializeField] Vector2 _middlePoint;//�Ȑ��̒��Ԓn�_
    [SerializeField] Vector2 _lastPoint;//�Ȑ��̏I�ǒn�_
    //float _answear = 0;
    float a;
    float b;
    float c;
    float _case;
    float _case1;
    float _case2;
    float _case3;
    // Start is called before the first frame update
    void Start()
    {
        _case1 = Quadraticfunctions(_firstPoint);
        _case2 = Quadraticfunctions(_middlePoint);
        _case3 = Quadraticfunctions(_lastPoint);
    }
    
    float Quadraticfunctions(Vector2 point)
    {
        float xx = point.x * point.x;
        _case = (a * xx) + (b * point.x);
        return _case;
    }
    //y = axx + bx 
    //float Renritu (Vector2 point)
    //{
    //    b = point.y / point.x - a * point.x;
    //}
}
