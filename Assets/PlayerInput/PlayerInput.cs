// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""9128151e-d036-461e-b4f4-1f3ac9ae4bbd"",
            ""actions"": [
                {
                    ""name"": ""Build"",
                    ""type"": ""Button"",
                    ""id"": ""de3dacf9-324e-423f-93de-f2b33f0fdb9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Invert"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Collect"",
                    ""type"": ""Button"",
                    ""id"": ""02d0fd3d-5595-4caa-8d0e-1c3eeacf8aab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""c9230b3e-f6d2-4579-bb61-bedbc2bece07"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""14567337-f0e6-4667-9695-acd48d98771d"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Build"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bacf167-8eff-4dc8-9561-629e8347a37f"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Build"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dc8dc18-cc04-43ba-95a6-90c3f42a1eef"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c557bdf-5fb8-4f2f-868d-e47693851962"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2ee395e-59d0-4b67-89c3-616310ef3bc2"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80fa84f5-91ab-467d-96a8-f515be70b49d"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": []
        },
        {
            ""name"": ""TouchScreen"",
            ""bindingGroup"": ""TouchScreen"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Build = m_Player.FindAction("Build", throwIfNotFound: true);
        m_Player_Collect = m_Player.FindAction("Collect", throwIfNotFound: true);
        m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Build;
    private readonly InputAction m_Player_Collect;
    private readonly InputAction m_Player_MousePosition;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Build => m_Wrapper.m_Player_Build;
        public InputAction @Collect => m_Wrapper.m_Player_Collect;
        public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Build.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBuild;
                @Build.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBuild;
                @Build.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBuild;
                @Collect.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollect;
                @Collect.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollect;
                @Collect.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollect;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Build.started += instance.OnBuild;
                @Build.performed += instance.OnBuild;
                @Build.canceled += instance.OnBuild;
                @Collect.started += instance.OnCollect;
                @Collect.performed += instance.OnCollect;
                @Collect.canceled += instance.OnCollect;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_TouchScreenSchemeIndex = -1;
    public InputControlScheme TouchScreenScheme
    {
        get
        {
            if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
            return asset.controlSchemes[m_TouchScreenSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnBuild(InputAction.CallbackContext context);
        void OnCollect(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
