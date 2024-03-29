﻿using UnityEngine;
using UnityEngine.AI;

public class EnemyDeathState : EnemyBaseState
{
  private readonly NavMeshAgent agent;

  public EnemyDeathState(EnemyController enemy, Animator animator, NavMeshAgent agent) : base(enemy, animator)
  {
    this.agent = agent;
  }

  public override void OnEnter()
  {
    animator.CrossFade(DeathHash, crossFadeDuration);
  }

  public override void Update()
  {
    agent.SetDestination(enemy.transform.position);
  }
}
