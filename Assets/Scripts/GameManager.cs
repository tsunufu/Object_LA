using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyBoss boss;
    public Player player;
    public Healer healer;

    /// <summary>
    /// Enemyが攻撃を受けた際に実行する処理
    /// </summary>
    public void EnemyDamage(float power)
    {
        boss.AddDamage(power);
    }

    /// <summary>
    /// Playerが攻撃を受けた際に実行する処理
    /// </summary>
    public void OnPlayersDamage(int damage)
    {
        player.AddDamage(damage);
        healer.AddDamage(damage);
    }

    /// <summary>
    /// Playerのヒールを実行する処理
    /// </summary>
    public void OnPlayerHeal()
    {
        player.AddHP();
    }

    //以下ボタンで押された際の処理
    /// <summary>
    /// 「PlayersAttackButton」が押されたときに実行
    /// </summary>
    public void OnPlayersAttack()
    {
        player.OnAttack();
        healer.OnAttack();
    }

    /// <summary>
    /// 「EnemyAttackButton」が押されたときに実行
    /// </summary>
    public void OnEnemyAttack()
    {
        boss.OnAttack();
    }

    /// <summary>
    /// 「PlayerSpSkillButton」が押されたときに実行
    /// </summary>
    public void OnPlayerSpSkill()
    {
        player.OnSpSkill();
    }

    /// <summary>
    /// 「PlayersAttackButton」が押されたときに実行
    /// </summary>
    public void OnHealerSpSkill()
    {
        healer.OnSpSkill();
    }
}
