using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR.ARFoundation;

public class NavMeshAgentFollowARCamera : MonoBehaviour
{
    public Camera arCamera; // Reference to the AR camera
    public NavMeshAgent agent; // Reference to the NavMeshAgent

    void Start()
    {
        if (arCamera == null)
        {
            arCamera = Camera.main; // Use the main camera if AR camera not set
        }

        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        if (arCamera != null && agent != null)
        {
            // Set the destination of the NavMeshAgent to the AR camera's position
            Vector3 targetPosition = arCamera.transform.position;

            // Adjust the target position to stay on the NavMesh plane
            targetPosition.y = 0; // Assuming the NavMesh is on a flat plane at y = 0

            agent.SetDestination(targetPosition);
        }
    }
}

