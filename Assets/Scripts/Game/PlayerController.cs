using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Collider))]
public abstract class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float stopTime = 3F;

    TagCounter tagCounter;

    
    //[SerializeField] protected Camera thisCamera;

    protected NavMeshAgent agent { get; set; }

    public bool IsTagged { get; protected set; }

    public void SwitchRoles()
    {
        IsTagged = !IsTagged;

        Debug.Log("Cambio");

        // Pause all logic and restart after
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(GetLocation());
            GoToLocation(GetLocation());

        }
        
    }
    protected abstract Vector3 GetLocation();

    public void GoToLocation(Vector3 location)
    {
        agent.SetDestination(location);
    }

    public virtual IEnumerator StopLogic()
    {
        
        // Stop BT runner if AI player, else stop movement.
        

        yield return new WaitForSeconds(stopTime);
        
        // Restart stuff.
    }

    

    // Start is called before the first frame update
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Debug.Log(agent);
    }

    private void OnCollisionEnter(Collision collision)
    {
        SwitchRoles();

        if (collision.gameObject.tag == "Player" )
        {
            if (IsTagged)
            {
                StopLogic();
            }
        }
        

        
    }
}