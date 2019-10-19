using UnityEngine;

namespace AI
{
    public abstract class SelectWithOption : Node
    {
        [SerializeField]
        private Group successTree;

        [SerializeField]
        private Group failTree;

        protected bool stopBT;

    
        public override void Execute()
        {
            if (!stopBT)
            {
                if (Check())
                {
                    successTree.Execute();
                }
                else
                {
                    failTree.Execute();
                }
            }
            
        }
        public abstract bool Check();
    }
}