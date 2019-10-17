using AI;
using System.Linq;
using UnityEngine;

public class GetNearestTarget : Node
{
    public AIController aiController;

    public override void Execute()
    {
        GameObject target;
        float minDistance = 1000;

        for (int i = 0; i < aiController.enemies.Length; i++)
        {
            if (minDistance > (transform.position - aiController.transform.position).magnitude)
            {
                minDistance = ((transform.position - aiController.transform.position).magnitude);
                target = aiController.enemies[i].gameObject;
            }
            
        }

        //throw new System.NotImplementedException();

        
    }
}