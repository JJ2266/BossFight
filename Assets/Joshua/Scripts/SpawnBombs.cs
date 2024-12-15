using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Joshua
{
    public class SpawnBombs : StateMachineBehaviour
    {
        Transform target;
        [SerializeField] GameObject bomb;
        [SerializeField] float spawnRate;
        float time;
        float elapsed;
        public int rand;
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

            target = FindObjectOfType<PlayerLogic>().GetComponent<Transform>();
            rand = Random.Range(5, 10);
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            elapsed += Time.deltaTime;
            time += Time.deltaTime;

            if (elapsed < rand)
            {
                if (time >= spawnRate)
                {
                    time = 0;
                    Instantiate(bomb, new Vector3(target.transform.position.x, target.transform.position.y + 20, target.transform.position.z), Quaternion.identity);
                }
            }
            if (elapsed > rand)
            {
                animator.SetBool("Bombs", false);
            }


        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            elapsed = 0;
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