using AI;
using UnityEngine;

[RequireComponent(typeof(BehaviourRunner))]
public class AIController : PlayerController
{
    protected GameObject[] playersGroup;
    public Transform[] enemies;

    private void Start()
    {
        playersGroup = GameObject.FindGameObjectsWithTag("Player");
        enemies = new Transform[playersGroup.Length];

        for (int i = 0; i < playersGroup.Length; i++)
        {
            enemies[i] = playersGroup[i].GetComponent<Transform>();

        }

    }

    protected override Vector3 GetLocation()
    {


        throw new System.NotImplementedException();
    }

    public void Update()
    {
        for (int i = 0; i < playersGroup.Length; i++)
        {
            
        }
    }
}