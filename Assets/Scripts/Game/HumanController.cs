using UnityEngine;

public class HumanController : PlayerController
{

    protected override Vector3 GetLocation()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        
        return Physics.Raycast(ray, out hit, 1<<9) ? hit.point : transform.position;
    }

    

    

    
}