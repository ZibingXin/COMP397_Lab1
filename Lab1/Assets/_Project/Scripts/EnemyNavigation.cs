using UnityEngine;
using UnityEngine.AI;

namespace Platformer397
{
    public class EnemyNavigation : MonoBehaviour
    {
        private NavMeshAgent agent;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }
        void Update()
        {
            var destination = GameObject.FindWithTag("Player").transform.position;
            agent.destination = destination;
        }

    }
}
