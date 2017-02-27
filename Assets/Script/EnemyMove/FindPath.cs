using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindPath : MonoBehaviour
{
    [Header("Target")]
    [SerializeField]
    Transform player;
    [SerializeField]
    Transform start, goal;

    [Header("Component Param")]
    [SerializeField]
    float speed = 10;

    const int maxPosition = 9;

    NavMeshPath path = null;
    Vector3[] positions = new Vector3[maxPosition];

    int currentPositionIndex = 0;

    void Start()
    {
        path = new NavMeshPath();
        NavMesh.CalculatePath(start.localPosition, goal.localPosition, NavMesh.AllAreas, path);
        path.GetCornersNonAlloc(positions);
    }

    private void Update()
    {
        var tragetPosition = positions[currentPositionIndex];
        if (Vector3.Distance(player.localPosition, tragetPosition) < 0.2f)
        {
            currentPositionIndex = currentPositionIndex + 1 < positions.Length ? currentPositionIndex + 1 : currentPositionIndex;
        }

        player.localPosition = Vector3.MoveTowards(player.localPosition, tragetPosition, speed * Time.deltaTime);
    }

    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < positions.Length - 1; i++)
        {
            Gizmos.DrawLine(positions[i], positions[i + 1]);
        }
    }
}