using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoTo : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private NavMeshAgent Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.destination = _target.transform.position;
    }
}
