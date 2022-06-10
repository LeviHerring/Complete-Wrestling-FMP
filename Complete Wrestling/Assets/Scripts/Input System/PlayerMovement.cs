// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input System/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
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
                    ""type"": ""Button"",
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
                },
                {
                    ""name"": ""Down tilt"",
                    ""type"": ""Button"",
                    ""id"": ""c0ae2745-1f03-41f2-96f5-b35371c64b63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""down smash"",
                    ""type"": ""Button"",
                    ""id"": ""5accc085-d357-4494-86dc-eaf37e84d331"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up smash"",
                    ""type"": ""Button"",
                    ""id"": ""58d6ae47-942e-4c00-aec3-87573990563d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up b"",
                    ""type"": ""Button"",
                    ""id"": ""4f4738db-2ad4-4660-847c-c0688028abce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""down air"",
                    ""type"": ""Button"",
                    ""id"": ""d414642f-128b-4195-89f6-3e412dc35558"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up air"",
                    ""type"": ""Button"",
                    ""id"": ""aefc8477-1da6-426e-b218-7c3f7238563b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""down strong air"",
                    ""type"": ""Button"",
                    ""id"": ""b7193009-2984-416d-934b-dfa1a4fe3d41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""up strong air"",
                    ""type"": ""Button"",
                    ""id"": ""3087c61a-54f1-4776-9ba3-3ef83846a72e"",
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
                    ""id"": ""64def2b0-4fd1-4068-94fe-4b022b2d2986"",
                    ""path"": ""<Keyboard>/space"",
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
                    ""name"": ""WASD"",
                    ""id"": ""2af41972-8b49-4b41-b857-8650c7934040"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6b949a1a-654a-4f47-b097-842d9ea1f2e6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f9410b6d-7779-4547-bdd5-0a9a55eda7ea"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eedb9055-ccd6-4e08-82ce-ca2cd3ba9529"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf0ae2a5-3ea4-4ca9-b88b-15fcbff372de"",
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
                    ""id"": ""355b5b36-5981-47e0-b945-e87902d5256b"",
                    ""path"": ""<Keyboard>/leftShift"",
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
                    ""id"": ""c6efe861-d82a-4e4a-92b0-64675b8fd3ac"",
                    ""path"": ""<Keyboard>/p"",
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
                    ""id"": ""55939bef-665e-4d10-aee3-d4739ee98afc"",
                    ""path"": ""<Keyboard>/i"",
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
                    ""id"": ""12c4e56b-de54-4e73-8296-128b110903fa"",
                    ""path"": ""<Keyboard>/o"",
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
                    ""id"": ""732fd603-0f13-4df3-ba3a-d79d202d5526"",
                    ""path"": ""<Keyboard>/p"",
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
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d67497c7-d752-4c5e-b9ec-fbb6c5ae4d32"",
                    ""path"": ""<Keyboard>/semicolon"",
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
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToPinSomeone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd7abe73-c6e9-473f-9d39-12d848e2d057"",
                    ""path"": ""<Keyboard>/quote"",
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
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Super Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4e75afe-3d6c-4709-8df6-890cf09ab5c3"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Super Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03801007-d6e5-4243-841b-d833c547157a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df81c9a8-2f93-4e8c-bf83-b0e524b60465"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Down and B"",
                    ""id"": ""9887810d-6d9a-4dd9-a9a0-a381cf91579e"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""b571a815-7f74-4481-a4ac-17f95ca4b2ee"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""2b18f2a1-f7cb-4376-9e9f-95ff4294b38c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""S and I"",
                    ""id"": ""c424ae71-6ead-4496-8082-12d7aa637f63"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""302806a5-b118-4c97-af85-0cd2891869f7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ffa1a4aa-12bf-45da-9fa1-cb35049d8566"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                },
                {
                    ""name"": """",
                    ""id"": ""69b75971-4389-4512-a97c-19505b390096"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up and A"",
                    ""id"": ""d6f3e6ee-7c52-4fa5-b166-9e032d5b4c6e"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""9d11955a-b183-4391-8936-8595e1ad2c6a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""0961b917-13c5-4eff-bf2f-cb2a44189e60"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""W and P"",
                    ""id"": ""e0e6dc3e-bf0a-4bf9-bfe4-c5e0c6a5c64a"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""16515f60-36a8-4224-8963-f1f624f1d043"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""c92aee03-9aae-440a-8ebd-e7e8dd499871"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down and A"",
                    ""id"": ""b93ff622-7423-4faa-a1bf-3f15139bad09"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down tilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""c973c218-62ab-4550-bce2-107a78897cac"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""47496de6-ee59-468b-bbec-9e173ee03a7b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d9cac450-b02e-40a9-8507-86050fd80a4e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up and a"",
                    ""id"": ""b33d49bb-c692-4372-a129-93f9ffb252f6"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up air"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""66f2a97b-38b6-46de-b18d-43c7994108ca"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""3192e0ef-6e76-4a61-a31e-65390e063a48"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3c07b1f7-70d5-47ad-a658-7953db39dba9"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down strong air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down and x"",
                    ""id"": ""b4780267-6f4a-4c9b-887a-aedf03dff303"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down strong air"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""30f2256f-03b0-44e4-bb70-0c00d7a005bd"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down strong air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""bf484139-60ab-404c-bece-e52ae9259334"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down strong air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up and x"",
                    ""id"": ""6b6781cb-edf9-41b9-9bd1-2ab5e5746e17"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up strong air"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""444bf3f0-c938-4d4d-b2f3-1e41b9416870"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up strong air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""f43b9211-68e1-4a93-b3f3-ea28677e4804"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up strong air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down and x"",
                    ""id"": ""e17f9449-e3a3-4f0e-8bdc-340dd79796a3"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down smash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ac0b995e-f473-4ca3-9157-681c84c1c445"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down smash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""17c62516-c3aa-45af-83f5-1c4cec4237d9"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down smash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up and X"",
                    ""id"": ""533b8ad8-751d-41b6-b98c-1a03fce253c7"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up smash"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8bf13c10-507c-4adc-9635-b53445eef617"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up smash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""a6bed696-4585-4077-84fd-a1a9338c99e9"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up smash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up and b"",
                    ""id"": ""ddc6d0f3-3ca0-460e-8a76-47fdec22eb14"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up b"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""fa044e63-258f-47bf-b900-0b89d79a27eb"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up b"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""9b028d84-94d8-432b-afcb-47f2b1b8d837"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up b"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down and a "",
                    ""id"": ""d90ecfc2-7fce-4316-b6c0-bc5ae01fbcd2"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down air"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""afa0db55-885a-4f0f-83a1-4b41b4db011d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""554690b1-6714-4580-9101-5bb09c66b5c8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down air"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        m_Player_Downtilt = m_Player.FindAction("Down tilt", throwIfNotFound: true);
        m_Player_downsmash = m_Player.FindAction("down smash", throwIfNotFound: true);
        m_Player_upsmash = m_Player.FindAction("up smash", throwIfNotFound: true);
        m_Player_upb = m_Player.FindAction("up b", throwIfNotFound: true);
        m_Player_downair = m_Player.FindAction("down air", throwIfNotFound: true);
        m_Player_upair = m_Player.FindAction("up air", throwIfNotFound: true);
        m_Player_downstrongair = m_Player.FindAction("down strong air", throwIfNotFound: true);
        m_Player_upstrongair = m_Player.FindAction("up strong air", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Downtilt;
    private readonly InputAction m_Player_downsmash;
    private readonly InputAction m_Player_upsmash;
    private readonly InputAction m_Player_upb;
    private readonly InputAction m_Player_downair;
    private readonly InputAction m_Player_upair;
    private readonly InputAction m_Player_downstrongair;
    private readonly InputAction m_Player_upstrongair;
    public struct PlayerActions
    {
        private @PlayerMovement m_Wrapper;
        public PlayerActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
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
        public InputAction @Downtilt => m_Wrapper.m_Player_Downtilt;
        public InputAction @downsmash => m_Wrapper.m_Player_downsmash;
        public InputAction @upsmash => m_Wrapper.m_Player_upsmash;
        public InputAction @upb => m_Wrapper.m_Player_upb;
        public InputAction @downair => m_Wrapper.m_Player_downair;
        public InputAction @upair => m_Wrapper.m_Player_upair;
        public InputAction @downstrongair => m_Wrapper.m_Player_downstrongair;
        public InputAction @upstrongair => m_Wrapper.m_Player_upstrongair;
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
                @Downtilt.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDowntilt;
                @Downtilt.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDowntilt;
                @Downtilt.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDowntilt;
                @downsmash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownsmash;
                @downsmash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownsmash;
                @downsmash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownsmash;
                @upsmash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpsmash;
                @upsmash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpsmash;
                @upsmash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpsmash;
                @upb.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpb;
                @upb.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpb;
                @upb.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpb;
                @downair.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownair;
                @downair.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownair;
                @downair.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownair;
                @upair.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpair;
                @upair.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpair;
                @upair.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpair;
                @downstrongair.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownstrongair;
                @downstrongair.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownstrongair;
                @downstrongair.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDownstrongair;
                @upstrongair.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpstrongair;
                @upstrongair.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpstrongair;
                @upstrongair.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpstrongair;
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
                @Downtilt.started += instance.OnDowntilt;
                @Downtilt.performed += instance.OnDowntilt;
                @Downtilt.canceled += instance.OnDowntilt;
                @downsmash.started += instance.OnDownsmash;
                @downsmash.performed += instance.OnDownsmash;
                @downsmash.canceled += instance.OnDownsmash;
                @upsmash.started += instance.OnUpsmash;
                @upsmash.performed += instance.OnUpsmash;
                @upsmash.canceled += instance.OnUpsmash;
                @upb.started += instance.OnUpb;
                @upb.performed += instance.OnUpb;
                @upb.canceled += instance.OnUpb;
                @downair.started += instance.OnDownair;
                @downair.performed += instance.OnDownair;
                @downair.canceled += instance.OnDownair;
                @upair.started += instance.OnUpair;
                @upair.performed += instance.OnUpair;
                @upair.canceled += instance.OnUpair;
                @downstrongair.started += instance.OnDownstrongair;
                @downstrongair.performed += instance.OnDownstrongair;
                @downstrongair.canceled += instance.OnDownstrongair;
                @upstrongair.started += instance.OnUpstrongair;
                @upstrongair.performed += instance.OnUpstrongair;
                @upstrongair.canceled += instance.OnUpstrongair;
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
        void OnDowntilt(InputAction.CallbackContext context);
        void OnDownsmash(InputAction.CallbackContext context);
        void OnUpsmash(InputAction.CallbackContext context);
        void OnUpb(InputAction.CallbackContext context);
        void OnDownair(InputAction.CallbackContext context);
        void OnUpair(InputAction.CallbackContext context);
        void OnDownstrongair(InputAction.CallbackContext context);
        void OnUpstrongair(InputAction.CallbackContext context);
    }
}
