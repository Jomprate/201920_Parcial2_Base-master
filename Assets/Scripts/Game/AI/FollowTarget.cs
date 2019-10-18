
using AI;
using UnityEngine;

public class FollowTarget : Node
{
    GetNearestTarget getNearestTarget;
    AIController aIController;
    Node node;

    

    public override void Execute()
    {
        transform.LookAt(target.transform); //Update the LookAT transform

        
        



        //throw new System.NotImplementedException();
    }
    private void Update()
    {
        
    }

}