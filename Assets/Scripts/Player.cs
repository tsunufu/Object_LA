using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Friendly
{
    public void AddHP()
    {
        hp += 10;
        DisplayHpValue();
    }

    public override void AddDamage(int damage)
    {
        damage = Random.Range(0, 11);
        hp -= damage;

        DisplayHpValue();
    }

    public override void OnAttack()
    {
        Debug.Log("Playerテク子の攻撃！");
        gameManager.EnemyDamage(attackPower);
    }

    public override void OnSpSkill()
    {
        Debug.Log("Playerのスキル発動！Enemyへ2倍攻撃！");
        gameManager.EnemyDamage(2 * attackPower);
    }
}
