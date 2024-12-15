using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.AI;
using UnityEngine.AI;

namespace Joshua
{
    public class BossAI : MonoBehaviour
    {
        [SerializeField] GameObject SwordProjectile;
        [SerializeField] GameObject Saw;
        [SerializeField] GameObject SawSpawnParticle;
        [SerializeField] GameObject BlackHole;
        [SerializeField] GameObject BlackHoleHazards;
        Damageable damageable;
        bool phase2 = false;
        bool phase3 = false;
        [SerializeField] Transform player;
        Rigidbody rb;
        Navigator navigator;
        Animator anim;
        NavMeshAgent agent;
        public float elapsed;
        // Start is called before the first frame update
        void Start()
        {
            navigator = GetComponent<Navigator>();
            rb = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
            agent = GetComponent<NavMeshAgent>();
            damageable = GetComponent<Damageable>();
        }

        // Update is called once per frame
        void Update()
        {
            if (damageable.currentHealth <= 50)
            {
                phase2 = true;
                anim.SetBool("Phase2", true);
            }
            if (damageable.currentHealth <= 13)
            {
                phase3 = true;
                anim.SetBool("Phase3", true);
                transform.position = new Vector3(-0.310000002f, 0.649999976f, 5.44999981f);
                transform.LookAt(new Vector3(0.0400000811f, 1.67999995f, 2.28999996f));
                BlackHole.SetActive(true);
                BlackHoleHazards.SetActive(true);
                DectivateSaw();
            }
        }
        public void SpawnSwordProjectiles()
        {
            if (phase2 == true)
            {
                GameObject p = Instantiate(SwordProjectile, transform.position, Quaternion.identity);
                p.transform.forward = transform.forward;
            }
            else
                return;
        }
        public void SwordSwing()
        {
            LookAtPlayer();
            anim.SetTrigger("Sword");
        }
        public void ActivateSaw()
        {
            if (Saw.active == false)
            {
                Saw.SetActive(true);
                var p = Instantiate(SawSpawnParticle, Saw.transform.position, Quaternion.identity);
                p.transform.localScale = new Vector3(4, 4, 4);
            }
            else
                return;

        }
        public void DectivateSaw()
        {
            if (Saw.active == true)
            {
                Saw.SetActive(false);
                var p = Instantiate(SawSpawnParticle, Saw.transform.position, Quaternion.identity);
                p.transform.localScale = new Vector3(4, 4, 4);
            }
            else
                return;

        }
        public void Pursue()
        {

            agent.SetDestination(player.transform.position);
        }
        public void LookAtPlayer()
        {
            transform.LookAt(player);
        }
    }
}

