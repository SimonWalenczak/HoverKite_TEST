using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
    public class InputManagement : MonoBehaviour
    {
        private CharacterMultiplayerManager _characterMultiplayerManager;

        private GameplayInput _gameplayInput;

        private PlayerConfiguration _playerConfig;

        public GameplayInput GameplayInput
        {
            get { return _gameplayInput; }
            private set { _gameplayInput = value; }
        }

        [SerializeField] float DeadzoneJoystick = 0.3f;
        [SerializeField] float DeadzoneJoystickTrigger = 0.3f;
        [field: SerializeField] public InputsEnum Inputs { get; private set; }

        private void Awake()
        {
            _gameplayInput = new GameplayInput();
            _gameplayInput.Enable();
        }

        public void InitializePlayer(PlayerConfiguration pc)
        {
            _playerConfig = pc;

            _playerConfig.Input.onActionTriggered += GatherInputs;
        }

        private void GatherInputs(InputAction.CallbackContext context)
        {
            InputsEnum inputsEnum = Inputs;

            //Switch
            if (context.action.name == _gameplayInput.Rider.SwitchUp.name)
                inputsEnum.SwitchUp = context.ReadValue<float>() > DeadzoneJoystickTrigger;

            if (context.action.name == _gameplayInput.Rider.SwitchDown.name)
                inputsEnum.SwitchDown = context.ReadValue<float>() > DeadzoneJoystickTrigger;

            inputsEnum.Deadzone = DeadzoneJoystick;

            Inputs = inputsEnum;
        }
    }

    [Serializable]
    public struct InputsEnum
    {
        public bool SwitchUp;
        public bool SwitchDown;

        public float Deadzone;
    }
}