using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyBoss boss;
    // public Player player;
    // public Healer healer;

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
    public void OnPlayersDamage()
    {

    }

    /// <summary>
    /// Playerのヒールを実行する処理
    /// </summary>
    public void OnPlayerHeal()
    {

    }

    //以下ボタンで押された際の処理
    /// <summary>
    /// 「PlayersAttackButton」が押されたときに実行
    /// </summary>
    public void OnPlayersAttack()
    {

    }

    /// <summary>
    /// 「EnemyAttackButton」が押されたときに実行
    /// </summary>
    public void OnEnemyAttack()
    {

    }

    /// <summary>
    /// 「PlayerSpSkillButton」が押されたときに実行
    /// </summary>
    public void OnPlayerSpSkill()
    {

    }

    /// <summary>
    /// 「PlayersAttackButton」が押されたときに実行
    /// </summary>
    public void OnHealerSpSkill()
    {

    }
}
