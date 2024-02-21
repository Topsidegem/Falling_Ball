//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Cilindro.inputactions
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

public partial class @Cilindro : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Cilindro()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Cilindro"",
    ""maps"": [
        {
            ""name"": ""Girar"",
            ""id"": ""74a402bc-e34c-472e-8677-03469f082987"",
            ""actions"": [
                {
                    ""name"": ""Rotar"",
                    ""type"": ""Value"",
                    ""id"": ""42d81388-9ade-4635-bd64-1e6f5788730b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""eb5522ab-892a-400a-9e77-e60838382f6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3857abed-237f-4814-a141-37c63f6c6b76"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""88352ed4-0bae-4422-bba0-6745823386ea"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Girar
        m_Girar = asset.FindActionMap("Girar", throwIfNotFound: true);
        m_Girar_Rotar = m_Girar.FindAction("Rotar", throwIfNotFound: true);
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

    // Girar
    private readonly InputActionMap m_Girar;
    private IGirarActions m_GirarActionsCallbackInterface;
    private readonly InputAction m_Girar_Rotar;
    public struct GirarActions
    {
        private @Cilindro m_Wrapper;
        public GirarActions(@Cilindro wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotar => m_Wrapper.m_Girar_Rotar;
        public InputActionMap Get() { return m_Wrapper.m_Girar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GirarActions set) { return set.Get(); }
        public void SetCallbacks(IGirarActions instance)
        {
            if (m_Wrapper.m_GirarActionsCallbackInterface != null)
            {
                @Rotar.started -= m_Wrapper.m_GirarActionsCallbackInterface.OnRotar;
                @Rotar.performed -= m_Wrapper.m_GirarActionsCallbackInterface.OnRotar;
                @Rotar.canceled -= m_Wrapper.m_GirarActionsCallbackInterface.OnRotar;
            }
            m_Wrapper.m_GirarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotar.started += instance.OnRotar;
                @Rotar.performed += instance.OnRotar;
                @Rotar.canceled += instance.OnRotar;
            }
        }
    }
    public GirarActions @Girar => new GirarActions(this);
    public interface IGirarActions
    {
        void OnRotar(InputAction.CallbackContext context);
    }
}
