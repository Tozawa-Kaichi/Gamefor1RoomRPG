using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// HPを持ち、敵から攻撃を受けたとき、自身のHPを減らすことのできる機能を定めたインターフェース
/// 体力を持つオブジェクトに継承するべき
/// </summary>

public interface IDamageable 
{
    void AddDamage(float damage);//攻撃を与える側はこれを呼ぶ
}
