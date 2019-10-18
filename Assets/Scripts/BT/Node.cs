using UnityEngine;
using System.Collections;

namespace AI
{
	public abstract class Node : MonoBehaviour 
	{
        public GameObject target;
		public abstract void Execute ();

        
    }
}