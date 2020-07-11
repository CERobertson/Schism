// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""MenuOneDimensional"",
            ""id"": ""c652d1e9-a3e1-41c9-9f63-756169d9ebee"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""b9ef7d00-cb93-49b7-9f35-6e0bbad2d044"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07b59cde-4f03-4657-8b1b-72aedae28156"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad And Keyboard"",
            ""bindingGroup"": ""Gamepad And Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MenuOneDimensional
        m_MenuOneDimensional = asset.FindActionMap("MenuOneDimensional", throwIfNotFound: true);
        m_MenuOneDimensional_Newaction = m_MenuOneDimensional.FindAction("New action", throwIfNotFound: true);
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

    // MenuOneDimensional
    private readonly InputActionMap m_MenuOneDimensional;
    private IMenuOneDimensionalActions m_MenuOneDimensionalActionsCallbackInterface;
    private readonly InputAction m_MenuOneDimensional_Newaction;
    public struct MenuOneDimensionalActions
    {
        private @InputActions m_Wrapper;
        public MenuOneDimensionalActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_MenuOneDimensional_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MenuOneDimensional; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuOneDimensionalActions set) { return set.Get(); }
        public void SetCallbacks(IMenuOneDimensionalActions instance)
        {
            if (m_Wrapper.m_MenuOneDimensionalActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuOneDimensionalActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuOneDimensionalActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuOneDimensionalActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuOneDimensionalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuOneDimensionalActions @MenuOneDimensional => new MenuOneDimensionalActions(this);
    private int m_GamepadAndKeyboardSchemeIndex = -1;
    public InputControlScheme GamepadAndKeyboardScheme
    {
        get
        {
            if (m_GamepadAndKeyboardSchemeIndex == -1) m_GamepadAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("Gamepad And Keyboard");
            return asset.controlSchemes[m_GamepadAndKeyboardSchemeIndex];
        }
    }
    public interface IMenuOneDimensionalActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
