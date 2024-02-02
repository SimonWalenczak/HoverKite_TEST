//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/GameplayInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameplayInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayInput"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""277fdb27-a2da-4265-9e88-335aeec59c00"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ee1d262b-be45-4fa4-90c9-8bafb81e9d50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""bca9c0f9-e55a-4647-9ef9-0a8749e8f267"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""244ace43-f9fb-4819-bd22-0235f8d5c216"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""7e3d4f7e-b511-4e7a-84d9-ab3c55a97b25"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""d1803cfd-8d0d-4e09-bd9e-d17864d14560"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""461c14c8-db23-410e-be9a-edbfcb512757"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""12f53d93-ce5b-4e8b-86dc-a322426bc37e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""546a05c7-48de-4a6a-875c-6f7f2d2e6e4c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0ac6be1b-315a-4ea7-b601-93d9a1c38290"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e7a1b9c-d673-4b82-85bd-7356b5ef0034"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Rider"",
            ""id"": ""9188f3d0-8d9e-44d8-976a-486858db10de"",
            ""actions"": [
                {
                    ""name"": ""SwitchUp"",
                    ""type"": ""Button"",
                    ""id"": ""69ec6d2f-1d41-4934-95af-1eee4ed48fd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchDown"",
                    ""type"": ""Button"",
                    ""id"": ""eb263041-24aa-426e-bfa5-52e2e165c81a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85422489-56b0-4ecf-95ec-8505935de567"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2479a6ac-9b32-4d9a-bae8-2cb0417e29a1"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Move = m_Menu.FindAction("Move", throwIfNotFound: true);
        m_Menu_Submit = m_Menu.FindAction("Submit", throwIfNotFound: true);
        // Rider
        m_Rider = asset.FindActionMap("Rider", throwIfNotFound: true);
        m_Rider_SwitchUp = m_Rider.FindAction("SwitchUp", throwIfNotFound: true);
        m_Rider_SwitchDown = m_Rider.FindAction("SwitchDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_Move;
    private readonly InputAction m_Menu_Submit;
    public struct MenuActions
    {
        private @GameplayInput m_Wrapper;
        public MenuActions(@GameplayInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Menu_Move;
        public InputAction @Submit => m_Wrapper.m_Menu_Submit;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Submit.started += instance.OnSubmit;
            @Submit.performed += instance.OnSubmit;
            @Submit.canceled += instance.OnSubmit;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Submit.started -= instance.OnSubmit;
            @Submit.performed -= instance.OnSubmit;
            @Submit.canceled -= instance.OnSubmit;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Rider
    private readonly InputActionMap m_Rider;
    private List<IRiderActions> m_RiderActionsCallbackInterfaces = new List<IRiderActions>();
    private readonly InputAction m_Rider_SwitchUp;
    private readonly InputAction m_Rider_SwitchDown;
    public struct RiderActions
    {
        private @GameplayInput m_Wrapper;
        public RiderActions(@GameplayInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchUp => m_Wrapper.m_Rider_SwitchUp;
        public InputAction @SwitchDown => m_Wrapper.m_Rider_SwitchDown;
        public InputActionMap Get() { return m_Wrapper.m_Rider; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RiderActions set) { return set.Get(); }
        public void AddCallbacks(IRiderActions instance)
        {
            if (instance == null || m_Wrapper.m_RiderActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RiderActionsCallbackInterfaces.Add(instance);
            @SwitchUp.started += instance.OnSwitchUp;
            @SwitchUp.performed += instance.OnSwitchUp;
            @SwitchUp.canceled += instance.OnSwitchUp;
            @SwitchDown.started += instance.OnSwitchDown;
            @SwitchDown.performed += instance.OnSwitchDown;
            @SwitchDown.canceled += instance.OnSwitchDown;
        }

        private void UnregisterCallbacks(IRiderActions instance)
        {
            @SwitchUp.started -= instance.OnSwitchUp;
            @SwitchUp.performed -= instance.OnSwitchUp;
            @SwitchUp.canceled -= instance.OnSwitchUp;
            @SwitchDown.started -= instance.OnSwitchDown;
            @SwitchDown.performed -= instance.OnSwitchDown;
            @SwitchDown.canceled -= instance.OnSwitchDown;
        }

        public void RemoveCallbacks(IRiderActions instance)
        {
            if (m_Wrapper.m_RiderActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRiderActions instance)
        {
            foreach (var item in m_Wrapper.m_RiderActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RiderActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RiderActions @Rider => new RiderActions(this);
    public interface IMenuActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
    public interface IRiderActions
    {
        void OnSwitchUp(InputAction.CallbackContext context);
        void OnSwitchDown(InputAction.CallbackContext context);
    }
}