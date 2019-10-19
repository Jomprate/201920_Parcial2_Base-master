using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Collider))]
public abstract class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float stopTime = 3F;

    GameController gameController;
    
    TagCounter tagCounter;

    public bool canMove = true;

    //[SerializeField] protected Camera thisCamera;

    protected NavMeshAgent agent { get; set; }

    [Header("Tagged")]
    //public bool IsTagged { get; protected set; }
    public bool IsTagged;

    

    public void SwitchRoles()
    {
        IsTagged = !IsTagged;

        Debug.Log("Cambio");


        // Pause all logic and restart after
    }
    
    protected abstract Vector3 GetLocation();

    public void GoToLocation(Vector3 location)
    {
        agent.SetDestination(location);
    }

    public virtual IEnumerator StopLogic()
    {
        canMove = false;
        // Stop BT runner if AI player, else stop movement.

        yield return new WaitForSeconds(stopTime);

        canMove = true;
        // Restart stuff.
    }

    


    // Start is called before the first frame update
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Debug.Log(agent);
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    private void Update()
    {
        if (canMove)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(GetLocation());
                GoToLocation(GetLocation());

            }
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "Player" )
        {
            SwitchRoles();
            if (IsTagged)
            {
                StopLogic();
            }
        }
        

        
    }
}