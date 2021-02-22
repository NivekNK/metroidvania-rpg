using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NK 
{
	public class Player : MonoBehaviour
	{
		public PlayerStateMachine StateMachine { get; private set; }

        public PlayerIdleState IdleState { get; private set; }
        public PlayerMoveState MoveState { get; private set; }

        public Animator Anim { get; private set; }
        public InputManager InputManager { get; private set; }
        public Rigidbody2D RB { get; private set; }

        public Vector2 CurrentVelocity { get; private set; }

        [SerializeField] private PlayerAnimationData animData;
        [SerializeField] private PlayerData playerData;

        private Vector2 workspace;

        private void Awake()
        {
            StateMachine = new PlayerStateMachine();

            IdleState = new PlayerIdleState(this, StateMachine, playerData, animData.IDLE);
            MoveState = new PlayerMoveState(this, StateMachine, playerData, animData.MOVE);
        }

        private void Start()
        {
            Anim = GetComponent<Animator>();
            InputManager = GameManager.Instance.inputManager;
            RB = GetComponent<Rigidbody2D>();

            StateMachine.Initialize(IdleState);
        }

        private void Update()
        {
            CurrentVelocity = RB.velocity;

            StateMachine.CurrentState.LogicUpdate();
        }

        private void FixedUpdate()
        {
            StateMachine.CurrentState.PhysicsUpdate();
        }

        public void SetVelocityX(float velocity)
        {
            workspace.Set(velocity, CurrentVelocity.y);
            RB.velocity = workspace;
            CurrentVelocity = workspace;
        }
    }
}
