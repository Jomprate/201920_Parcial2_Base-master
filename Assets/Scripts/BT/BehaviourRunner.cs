using UnityEngine;
using System.Collections;


namespace AI
{
	public class BehaviourRunner: MonoBehaviour
	{
		[SerializeField]
		private Node root;

		[SerializeField]
		private float stepTime;

		private float elapsedTime;

        private bool logicIsStopped = false;

        public bool LogicIsStopped { get => this.logicIsStopped; set => this.logicIsStopped = value; }

        private void Update ()
		{
            if (!logicIsStopped)
            {
                elapsedTime += Time.deltaTime;
                if (elapsedTime >= stepTime)
                {
                    root.Execute();
                    elapsedTime = 0f;
                }
            }


			
		}
	}
}
