using AI;
using UnityEngine;

[RequireComponent(typeof(BehaviourRunner))]
public class AIController : PlayerController
{
    protected GameObject[] playersGroup;

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