using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent agent;
    
    public Transform[] points;
    public int index;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        index = Random.Range(0, points.Length);
    }

    void Update()
    {
        agent.SetDestination(points[index].position);
        
        if (agent.remainingDistance <= 1.5f) // 목적지와의 거리가 1.5 이하일 경우
        {
            Debug.Log("목적지 변경");

            int temp = index;
            index = Random.Range(0, points.Length);
            
            if (temp == index)
                index = Random.Range(0, points.Length);
        }
    }
}