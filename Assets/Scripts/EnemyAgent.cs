/*
using System;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class EnemyAgent3D : Agent
{
    public Transform shootingPoint;
    public float minStepsBetweenShots = 58;
    public int damage = 100;
    private void Shoot(Vector3 direction)
    {
        int layerMask = 1 << LayerMask.NameToLayer("Enemy");
        
        Debug.DrawRay(shootingPoint.position, direction,Color.green, 2f);

        if (Physics.Raycast(shootingPoint.position, direction, out var hit, 288f, layerMask))
        {
            hit.transform.GetComponent<Enemy>().GetShot(damage);
        }
    }

    private void OnMouseDown()
    {
        Shoot(-transform.right);
    }

    public override void Initialize()
    {
        // Initialization logic
    }

    public override void OnEpisodeBegin()
    {
        // Reset the environment and agent for a new training episode
        // For example, you might reset the position of the enemy and player
        
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Collect observations for the agent
        
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        // Perform actions based on the received actions from the model
        
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        // Define heuristic for manual control (optional)
        
    }
}
*/