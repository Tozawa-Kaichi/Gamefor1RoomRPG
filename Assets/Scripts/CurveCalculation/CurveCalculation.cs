using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 二次関数と連立方程式で曲線を計算するスクリプト
/// </summary>
public class CurveCalculation : MonoBehaviour
{
    [SerializeField] Vector2 _firstPoint;//曲線の開始地点
    [SerializeField] Vector2 _middlePoint;//曲線の中間地点
    [SerializeField] Vector2 _lastPoint;//曲線の終局地点
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
