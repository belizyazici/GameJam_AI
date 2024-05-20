using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject panel;
    [SerializeField] private Collider Detect, Leave, Human;
    [SerializeField] private Animator anim;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject Character;

    private bool isComing;
    public GameObject panel1;

    void Update()
    {
        if (isComing)
        {
            agent.SetDestination(Character.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Human)
        {
            isComing = true;
            anim.SetBool("isComing", true);
            anim.Play("BasicMotions@Run01 - Forwards");
            agent.SetDestination(Character.transform.position);
            
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other == Human)
        {
            isComing = true;
            anim.SetBool("isComing", true);
            anim.Play("BasicMotions@Run01 - Forwards");
            agent.SetDestination(Character.transform.position);
            panel1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == Human)
        {
            isComing = false;
            anim.SetBool("isComing", false);
            agent.SetDestination(transform.position); 
        }
    }
}