
using UnityEngine;
using UnityEngine.AI;

public class PlayerController6 : MonoBehaviour
{

    public Camera cam;

    public NavMeshAgent agent;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                MovePlayer(hit.point);
            };
        }
    }

    void MovePlayer(Vector3 position)
    {
        agent.SetDestination(position);
    }
}