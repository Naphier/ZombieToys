using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour
{
	[SerializeField] Transform target;
	[SerializeField] NavMeshAgent agent;
	[SerializeField] float updateDelay;

	void Reset()
	{
		if (!agent)
			agent = GetComponent<NavMeshAgent>();
	}

	void Start()
	{
		InvokeRepeating("FollowTarget", 0, updateDelay);
	}

	void FollowTarget()
	{
		agent.SetDestination(target.position);
	}
}
