using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Friendly
{

    public override void AddDamage(int damage)
    {
        damage = Random.Range(0, 21);
        hp -= damage;

        DisplayHpValue();
    }

    public override void OnAttack()
    {
        Debug.Log("ヒーラーウーノの攻撃！");
        gameManager.EnemyDamage(attackPower);
    }

    public override void OnSpSkill()
    {
        Debug.Log("ヒーラーのスキル発動！Playerを回復した！");
        gameManager.OnPlayerHeal();
    }
}
