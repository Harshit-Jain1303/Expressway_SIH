using UnityEngine;
using UnityEngine.AI;

public class NavMeshPathVisualizer : MonoBehaviour
{
    public NavMeshAgent agent; // Reference to the NavMeshAgent
    public Transform target; // Reference to the target
    public LineRenderer lineRenderer; // LineRenderer to visualize the path


    void Start()
    {
         lineRenderer = GetComponent<LineRenderer>();

        // Initialize the Line Renderer with two points
        if (lineRenderer != null)
        {
            lineRenderer.positionCount = 2;
        }

        if (agent == null)
        {
            Debug.LogError("NavMeshAgent is not assigned!");
        }
        if (target == null)
        {
            Debug.LogError("Target is not assigned!");
        }

        


    }

    void Update()
    {
        if (lineRenderer != null && source != null && target != null)
        {
            // Set the start point of the line to the source position
            lineRenderer.SetPosition(0, source.position);

            // Set the end point of the line to the target position
            lineRenderer.SetPosition(1, target.position);
            
            DrawPath();
    }

    void DrawPath()
    {
        // Get the calculated path from the NavMeshAgent
        NavMeshPath path = agent.path;

        if (path.corners.Length > 0)
        {
            // Update the LineRenderer to match the path
            Debug.Log(" no happen");
            lineRenderer.positionCount = path.corners.Length;
            lineRenderer.SetPositions(path.corners);
        }

    }

}
}