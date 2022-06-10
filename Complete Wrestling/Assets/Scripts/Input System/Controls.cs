// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input System/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4837a034-8434-4574-8e3a-cad3fbda3d97"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""16f73f7a-30ee-4cb3-971b-beb4dc615b99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""69c55be8-e0a2-40e6-baa7-3aebd63988ef"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Air Dash"",
                    ""type"": ""Button"",
                    ""id"": ""20e1c919-321a-4d87-8f3e-94c731094f82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Neutral Attack"",
                    ""type"": ""Button"",
                    ""id"": ""205c49b8-4dd5-4caa-a442-e54a6099fb38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""150ae4b6-d978-4c91-a482-e05c236cefac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down B"",
                    ""type"": ""Button"",
                    ""id"": ""e463154f-8f4d-45d2-b875-0e6b747d9c2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""02db68ba-e410-465e-804f-297bbb9e995c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up Tilt"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ac58de69-d6ff-4c73-bdf8-cbba580136ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Super Attack"",
                    ""type"": ""Button"",
                    ""id"": ""b04d15c4-6514-47f4-836c-34fcebf359bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToPinSomeone"",
                    ""type"": ""Button"",
                    ""id"": ""c17b8b14-dafc-4eb2-a814-b1d3db23317c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""5709020a-503e-4543-95d9-fc4ee4039305"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mashing"",
                    ""type"": ""Button"",
                    ""id"": ""8ffa5dca-bf40-4c2b-9ae8-5436298b8aeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strong Attack"",
                    ""type"": ""Button"",
                    ""id"": ""41c76f69-fc63-428b-bae5-ec0fb6504f90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look Down"",
                    ""type"": ""Button"",
                    ""id"": ""6c9cae7a-e4ea-4c69-a12d-628d9d440980"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look Left "",
                    ""type"": ""Button"",
                    ""id"": ""9ee5db3f-ad20-42d7-9c52-62f010f4a719"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look RIght"",
                    ""type"": ""Button"",
                    ""id"": ""0197b08a-8a09-4fd4-aca8-078a6a924de5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look up"",
                    ""type"": ""Button"",
                    ""id"": ""0f2d0de1-7c3b-4819-a09e-5247cdb63d6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Picture in Picture"",
                    ""type"": ""Button"",
                    ""id"": ""2729ec44-c565-4ce6-a557-ae712605259d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""a4402376-a96d-47e3-ae50-e0721e1b453e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dd389f2a-f1b0-4335-a62c-ac10370f9aa1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9addc66c-3fc9-44fd-a632-7d75651e2472"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01e10cff-e592-4aad-9464-ddd0ea021961"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Air Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23036db5-7705-4004-bc7e-4390fd38ccc0"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c90f6bef-b2e1-4ccf-8580-b73fbbfc8d9b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look Left "",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ba7b2c-992b-4ff3-8345-3f387487e837"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look RIght"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65e0fd80-a00d-4e69-aaa3-35c833f60598"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Neutral Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebaeea90-ea72-4f80-a30e-95fc2a9f7582"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e05b031e-27be-4c3c-963c-ec0c76513411"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strong Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04117408-1af5-452a-a136-03382c8ab802"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mashing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf9f4079-57a4-4b35-a189-c54e8f7857ab"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebe50a7a-7107-4cc7-8798-2cd96b0c9ecb"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToPinSomeone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8561640b-24a2-4485-aaac-927a92538255"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Super Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ac4d940-8138-4905-89d3-319de087d1f5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dac1630f-fca9-4e0c-b32b-cfa39557d0ba"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03801007-d6e5-4243-841b-d833c547157a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1643c95-b243-4659-9594-42bb9d7b0186"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b922f8fc-ea28-4916-b416-6edbd001afb3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37c92566-1381-4412-938c-8a3b934d420a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Picture in Picture"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac0b0d35-8314-45ba-afc2-5c774aa589ca"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_AirDash = m_Player.FindAction("Air Dash", throwIfNotFound: true);
        m_Player_NeutralAttack = m_Player.FindAction("Neutral Attack", throwIfNotFound: true);
        m_Player_Special = m_Player.FindAction("Special", throwIfNotFound: true);
        m_Player_DownB = m_Player.FindAction("Down B", throwIfNotFound: true);
        m_Player_Pickup = m_Player.FindAction("Pickup", throwIfNotFound: true);
        m_Player_UpTilt = m_Player.FindAction("Up Tilt", throwIfNotFound: true);
        m_Player_SuperAttack = m_Player.FindAction("Super Attack", throwIfNotFound: true);
        m_Player_ToPinSomeone = m_Player.FindAction("ToPinSomeone", throwIfNotFound: true);
        m_Player_Submit = m_Player.FindAction("Submit", throwIfNotFound: true);
        m_Player_Mashing = m_Player.FindAction("Mashing", throwIfNotFound: true);
        m_Player_StrongAttack = m_Player.FindAction("Strong Attack", throwIfNotFound: true);
        m_Player_LookDown = m_Player.FindAction("Look Down", throwIfNotFound: true);
        m_Player_LookLeft = m_Player.FindAction("Look Left ", throwIfNotFound: true);
        m_Player_LookRIght = m_Player.FindAction("Look RIght", throwIfNotFound: true);
        m_Player_Lookup = m_Player.FindAction("Look up", throwIfNotFound: true);
        m_Player_PictureinPicture = m_Player.FindAction("Picture in Picture", throwIfNotFound: true);
        m_Player_Select = m_Player.FindAction("Select", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_AirDash;
    private readonly InputAction m_Player_NeutralAttack;
    private readonly InputAction m_Player_Special;
    private readonly InputAction m_Player_DownB;
    private readonly InputAction m_Player_Pickup;
    private readonly InputAction m_Player_UpTilt;
    private readonly InputAction m_Player_SuperAttack;
    private readonly InputAction m_Player_ToPinSomeone;
    private readonly InputAction m_Player_Submit;
    private readonly InputAction m_Player_Mashing;
    private readonly InputAction m_Player_StrongAttack;
    private readonly InputAction m_Player_LookDown;
    private readonly InputAction m_Player_LookLeft;
    private readonly InputAction m_Player_LookRIght;
    private readonly InputAction m_Player_Lookup;
    private readonly InputAction m_Player_PictureinPicture;
    private readonly InputAction m_Player_Select;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @AirDash => m_Wrapper.m_Player_AirDash;
        public InputAction @NeutralAttack => m_Wrapper.m_Player_NeutralAttack;
        public InputAction @Special => m_Wrapper.m_Player_Special;
        public InputAction @DownB => m_Wrapper.m_Player_DownB;
        public InputAction @Pickup => m_Wrapper.m_Player_Pickup;
        public InputAction @UpTilt => m_Wrapper.m_Player_UpTilt;
        public InputAction @SuperAttack => m_Wrapper.m_Player_SuperAttack;
        public InputAction @ToPinSomeone => m_Wrapper.m_Player_ToPinSomeone;
        public InputAction @Submit => m_Wrapper.m_Player_Submit;
        public InputAction @Mashing => m_Wrapper.m_Player_Mashing;
        public InputAction @StrongAttack => m_Wrapper.m_Player_StrongAttack;
        public InputAction @LookDown => m_Wrapper.m_Player_LookDown;
        public InputAction @LookLeft => m_Wrapper.m_Player_LookLeft;
        public InputAction @LookRIght => m_Wrapper.m_Player_LookRIght;
        public InputAction @Lookup => m_Wrapper.m_Player_Lookup;
        public InputAction @PictureinPicture => m_Wrapper.m_Player_PictureinPicture;
        public InputAction @Select => m_Wrapper.m_Player_Select;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @AirDash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAirDash;
                @AirDash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAirDash;
                @AirDash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAirDash;
                @NeutralAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNeutralAttack;
                @NeutralAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNeutralAttack;
                @NeutralAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNeutralAttack;
                @Special.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpecial;
                @DownB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownB;
                @DownB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownB;
                @DownB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownB;
                @Pickup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @UpTilt.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpTilt;
                @UpTilt.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpTilt;
                @UpTilt.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpTilt;
                @SuperAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuperAttack;
                @SuperAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuperAttack;
                @SuperAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuperAttack;
                @ToPinSomeone.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToPinSomeone;
                @ToPinSomeone.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToPinSomeone;
                @ToPinSomeone.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToPinSomeone;
                @Submit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSubmit;
                @Mashing.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMashing;
                @Mashing.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMashing;
                @Mashing.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMashing;
                @StrongAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                @StrongAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                @StrongAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                @LookDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookDown;
                @LookDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookDown;
                @LookDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookDown;
                @LookLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookLeft;
                @LookLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookLeft;
                @LookLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookLeft;
                @LookRIght.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookRIght;
                @LookRIght.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookRIght;
                @LookRIght.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookRIght;
                @Lookup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookup;
                @Lookup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookup;
                @Lookup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLookup;
                @PictureinPicture.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPictureinPicture;
                @PictureinPicture.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPictureinPicture;
                @PictureinPicture.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPictureinPicture;
                @Select.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @AirDash.started += instance.OnAirDash;
                @AirDash.performed += instance.OnAirDash;
                @AirDash.canceled += instance.OnAirDash;
                @NeutralAttack.started += instance.OnNeutralAttack;
                @NeutralAttack.performed += instance.OnNeutralAttack;
                @NeutralAttack.canceled += instance.OnNeutralAttack;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
                @DownB.started += instance.OnDownB;
                @DownB.performed += instance.OnDownB;
                @DownB.canceled += instance.OnDownB;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @UpTilt.started += instance.OnUpTilt;
                @UpTilt.performed += instance.OnUpTilt;
                @UpTilt.canceled += instance.OnUpTilt;
                @SuperAttack.started += instance.OnSuperAttack;
                @SuperAttack.performed += instance.OnSuperAttack;
                @SuperAttack.canceled += instance.OnSuperAttack;
                @ToPinSomeone.started += instance.OnToPinSomeone;
                @ToPinSomeone.performed += instance.OnToPinSomeone;
                @ToPinSomeone.canceled += instance.OnToPinSomeone;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Mashing.started += instance.OnMashing;
                @Mashing.performed += instance.OnMashing;
                @Mashing.canceled += instance.OnMashing;
                @StrongAttack.started += instance.OnStrongAttack;
                @StrongAttack.performed += instance.OnStrongAttack;
                @StrongAttack.canceled += instance.OnStrongAttack;
                @LookDown.started += instance.OnLookDown;
                @LookDown.performed += instance.OnLookDown;
                @LookDown.canceled += instance.OnLookDown;
                @LookLeft.started += instance.OnLookLeft;
                @LookLeft.performed += instance.OnLookLeft;
                @LookLeft.canceled += instance.OnLookLeft;
                @LookRIght.started += instance.OnLookRIght;
                @LookRIght.performed += instance.OnLookRIght;
                @LookRIght.canceled += instance.OnLookRIght;
                @Lookup.started += instance.OnLookup;
                @Lookup.performed += instance.OnLookup;
                @Lookup.canceled += instance.OnLookup;
                @PictureinPicture.started += instance.OnPictureinPicture;
                @PictureinPicture.performed += instance.OnPictureinPicture;
                @PictureinPicture.canceled += instance.OnPictureinPicture;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnAirDash(InputAction.CallbackContext context);
        void OnNeutralAttack(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
        void OnDownB(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnUpTilt(InputAction.CallbackContext context);
        void OnSuperAttack(InputAction.CallbackContext context);
        void OnToPinSomeone(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnMashing(InputAction.CallbackContext context);
        void OnStrongAttack(InputAction.CallbackContext context);
        void OnLookDown(InputAction.CallbackContext context);
        void OnLookLeft(InputAction.CallbackContext context);
        void OnLookRIght(InputAction.CallbackContext context);
        void OnLookup(InputAction.CallbackContext context);
        void OnPictureinPicture(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
