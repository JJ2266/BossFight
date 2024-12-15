using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Joshua
{
    public class Idle : StateMachineBehaviour
    {
        [SerializeField] Transform Boss;
        [SerializeField] Transform Player;
        int rand;
        public float distance;

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Boss = FindObjectOfType<BossAI>().transform;
            Player = FindObjectOfType<PlayerLogic>().transform;
            rand = Random.Range(1, 4);
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            distance = Vector3.Distance(Player.transform.position, Boss.transform.position);
            switch (distance)
            {
                case <= 11:
                    //Mid

                    if (rand == 1)
                    {
                        animator.SetTrigger("Minigun");
                    }
                    else if (rand == 2)
                    {
                        animator.SetBool("Pursue", true);
                    }
                    else if (rand == 3)
                    {
                        animator.SetBool("Pursue", true);
                    }
                    break;
                case >= 12:
                    //Far

                    if (rand == 1)
                    {
                        animator.SetBool("Bombs", true);
                    }
                    else if (rand == 2)
                    {
                        animator.SetBool("Saw", true);
                    }
                    else if (rand == 3)
                    {
                        animator.SetTrigger("Minigun");
                    }

                    break;


            }
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }

        // OnStateMove is called right after Animator.OnAnimatorMove()
        //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        //{
        //    // Implement code that processes and affects root motion
        //}

        // OnStateIK is called right after Animator.OnAnimatorIK()
        //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        //{
        //    // Implement code that sets up animation IK (inverse kinematics)
        //}
    }
}