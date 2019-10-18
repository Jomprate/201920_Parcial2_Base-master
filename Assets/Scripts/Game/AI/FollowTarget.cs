using AI;

public class FollowTarget : Node
{
    GetNearestTarget getNearestTarget;
    AIController aIController;

    public override void Execute()
    {
        transform.LookAt(target.transform); //Update the LookAT transform

        

        

        throw new System.NotImplementedException();
    }
    private void Update()
    {
        
    }

}