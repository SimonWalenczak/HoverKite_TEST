using UnityEngine;

namespace Character
{
    public class CharacterManager : MonoBehaviour
    {
        public CharacterMultiplayerManager CharacterMultiplayerManager;
        
        #region Properties
        
        [field: SerializeField] public SwitchRails SwitchRailsProperty { get; private set; }
        [field: SerializeField] public InputManagement InputManagementProperty { get; private set; }

        #endregion
        
        
        public void SendDebugMessage(string message)
        {
            Debug.Log(message);
        }
    }
}
