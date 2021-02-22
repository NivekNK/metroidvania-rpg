using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NK 
{
    public class PlayerIdleState : PlayerGroundedState
    {
        public PlayerIdleState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName)
                               : base(player, stateMachine, playerData, animBoolName)
        {

        }

        public override void DoChecks()
        {
            base.DoChecks();
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            player.SetVelocityX(0f);

            if (input.x != 0f)
            {
                stateMachine.ChangeState(player.MoveState);
            }
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
