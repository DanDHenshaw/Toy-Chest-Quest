﻿using UnityEngine;
using UnityEngine.AI;

public class EnemyAttackState : EnemyBaseState
{
  private readonly NavMeshAgent agent;
  private readonly Transform target;

  public EnemyAttackState(EnemyController enemy, NavMeshAgent agent, Transform target) : base(enemy)
  {
    this.agent = agent;
    this.target = target;
  }

  public override void OnEnter()
  {
    animator.CrossFade(AttackHash, crossFadeDuration);
  }

  public override void Update()
  {
    agent.SetDestination(enemy.transform.position);

    enemy.Attack(AttackHash);
  }
}
