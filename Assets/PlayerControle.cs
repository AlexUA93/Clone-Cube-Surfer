// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControle.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControle : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControle()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControle"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""f6e300b7-6397-47ce-8c07-b4bcf3b51ca8"",
            ""actions"": [
                {
                    ""name"": ""MoveByMouse"",
                    ""type"": ""Value"",
                    ""id"": ""c05c9b16-ac89-4061-83a1-b7e1c7a5e228"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a87c639f-c0a6-4f01-9986-99fac6308baf"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveByMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_MoveByMouse = m_GamePlay.FindAction("MoveByMouse", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_MoveByMouse;
    public struct GamePlayActions
    {
        private @PlayerControle m_Wrapper;
        public GamePlayActions(@PlayerControle wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveByMouse => m_Wrapper.m_GamePlay_MoveByMouse;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @MoveByMouse.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveByMouse;
                @MoveByMouse.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveByMouse;
                @MoveByMouse.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveByMouse;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveByMouse.started += instance.OnMoveByMouse;
                @MoveByMouse.performed += instance.OnMoveByMouse;
                @MoveByMouse.canceled += instance.OnMoveByMouse;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnMoveByMouse(InputAction.CallbackContext context);
    }
}
