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
            ""name"": ""Any"",
            ""id"": ""06e29754-e027-448e-9432-9896cbcbb118"",
            ""actions"": [
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""1743f864-c34e-4ccb-8502-4b2d37a6603f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd40cf26-013f-48d5-b807-f4b45372bfaa"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cba67b16-4c0b-40a4-a96c-c45068a96f3a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02e193f7-24cb-47a0-9e8c-d138e06e66de"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24ab28dc-472f-484a-b870-d5c59b8d2c7f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f979383a-919a-4e6a-a6c7-d335efb23588"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73abb341-5271-4d88-bae3-43b552dcdd17"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab872778-395b-4227-81ba-6ed2f6648263"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c85c4942-cf70-459b-873a-9b9789a20d61"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02c1b307-2159-48e5-a391-01e8871cc6e0"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afacfcf8-c45f-44c4-a723-e12453cf7c3e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2acddd09-8940-430d-8b4e-b0366dc96585"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9549dda8-d067-4309-a594-5c9de355844e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f45a05b2-fda5-4c30-9f82-7033123792dd"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d5bb3ce-00e6-4367-beef-7fb4ce7536e8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62ff91b3-987a-46ed-9e97-688155629457"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2594055e-3044-4c79-9aa3-e7e83e381906"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c340f6a9-19e7-4f37-adf9-e67f1b67891d"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c74048bd-29ce-4124-a55b-0bb8460cb640"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69ce755e-2400-45c6-9f91-4fae70b3cffb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07fd7b77-80dd-4458-b33e-1876dd11be74"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51b4d569-64b1-43c9-8330-f008c15885fa"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58d81ebc-825a-4477-9821-ad69a2ef4bc5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9380eed7-ff50-4a57-a5dd-f2b684329daf"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8882d096-48e6-4cfb-8909-d46211611da4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ec9eabd-ce82-420f-a493-98e5044809bd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""One Dimension"",
            ""id"": ""c652d1e9-a3e1-41c9-9f63-756169d9ebee"",
            ""actions"": [
                {
                    ""name"": ""Positive"",
                    ""type"": ""Button"",
                    ""id"": ""80fba21f-c1d9-46d5-8b53-e6712f284dd4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Negative"",
                    ""type"": ""Button"",
                    ""id"": ""0038642e-a7d3-4098-8d98-6cc867082b28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""87b0fe76-5039-4d48-b059-59b720145f82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""701c0c58-caf7-45c4-8ed1-13fb8917daa0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b5a3a77-6a73-4838-af15-3001d3dcaa19"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da1e6523-52f8-4dad-9fbd-010ca5ee4f39"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9f4863d-6951-4f50-8cf6-19e4c8ddee38"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17ef25ce-75a9-4e09-b0e5-c4eba91c60cd"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84f53965-8ef9-46ec-baaf-a224aee2a3ea"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9425f89-78e7-4ce6-8e0e-e6eb5c890034"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6fe901d-cbb7-43ed-9f82-4a5a881258ce"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca41942b-e7c3-44e8-9c7b-bcfcee76bf19"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d56b2a09-956b-4b13-bdd8-b4b60811fafd"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaabb6c8-b050-4375-9fd4-13dd105265d8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab807aec-820d-4d4f-a0eb-dc432579000f"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fe208b2-58c1-42ed-93c7-c8281ff73b95"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c4ab288-8042-436d-9f52-88ee005bb606"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""381bc74c-50ab-4dad-a939-27c09a8aefb6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5677f3e-1862-46fe-a5b3-05b349473040"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Positive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00cf6ac3-2ebb-4ed8-84e2-daed1150048f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6319bee-f861-4ab9-acfe-ccfeff1e3c47"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""130dc2be-dc15-4202-8abf-b4dcc5daa6ca"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6181fa56-5fa0-40ea-bf01-af04fdecc9bf"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bc27784-c63a-4958-be22-c7820071ed0c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb996bea-5c32-4140-a3fa-2291ac1e28e2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a03f8f4-4ed7-44ef-9fad-41bcf46f82e9"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0422ebc-45c9-435e-85bf-fa1a6d75670a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f372c6be-31c0-4276-858f-8261784c2782"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64e570f3-1257-4b7e-ad48-2a388ef42095"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec989b15-861c-46b2-8f40-2b0027baf9d0"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0778a8a0-1b49-4fd8-8836-50727a370231"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5de72c93-5fa8-4dd5-858d-53c56d7a0a15"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f5835c2-ca20-4666-b3d0-580b11b0ba52"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ea1bb83-b5f4-4cab-add5-38611352fef6"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Negative"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""341b3c15-df77-4411-bbc0-02654fcab167"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11eef1cb-fc55-4daf-bfcf-efa0548bee1d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8544941a-a879-4b22-9949-572c1d4fb6ed"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1635908-5217-43f9-b8ae-c5343369837e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd1118e9-1bb8-4c08-bcc4-c21d05ffd011"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""825fdac0-fee0-4c47-98f9-2db3c1bb345b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""864b5958-7c50-4c9a-8300-538652c38ca1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27c73cbc-5cf0-4afa-823a-4249409a39eb"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eed3b27f-c03a-40d3-b8de-9d3dc9d3dd67"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77ce9e1d-d7fe-4373-b09b-983f55be83b5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""147d2aa7-dfcd-49ee-a644-e962e9a36510"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73686bdd-d251-42d7-a62e-06fe5e6a1b2c"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Basic"",
            ""id"": ""9a66d282-f992-4555-9f77-cf26c330d77e"",
            ""actions"": [
                {
                    ""name"": ""ToggleLookMode"",
                    ""type"": ""Button"",
                    ""id"": ""9e18fef2-685a-4fcb-bce5-56edc3ce56b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleConsole"",
                    ""type"": ""Value"",
                    ""id"": ""d90ad8b2-7135-4652-ba0e-cf2f2dafc6d5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd7cda68-4bdb-41eb-b8b0-77032a3142ed"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ToggleLookMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26c7f49a-0159-4e76-8343-805ac5e5d557"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""ToggleLookMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17fbaa8b-bb73-4422-bcd5-2b8b6e2d4745"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""ToggleConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Free Look"",
            ""id"": ""b43a0ff9-a868-49d7-9901-87e6883a4f8e"",
            ""actions"": [
                {
                    ""name"": ""Center"",
                    ""type"": ""Button"",
                    ""id"": ""4bae2e41-859d-4f2d-8f42-4edf26c96e80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""Value"",
                    ""id"": ""f2a0f094-afc5-44ac-8d96-3db18b301df3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""Value"",
                    ""id"": ""ad6aa17f-34c5-44ee-bd54-1a90b9fb25f8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""219c6d8e-a0c4-4624-914d-042f41488485"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AlignWithView"",
                    ""type"": ""Button"",
                    ""id"": ""573e28ad-ff62-4901-b139-2185bda5737c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3d31e2b2-813f-4566-847c-27c967f9a636"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e873b27-ff5e-43bc-82f7-ce68f7c52d26"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15dd40aa-52ed-44bd-8c10-c2de542c642d"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48699d05-80ed-4eb9-bc97-0ea34bfabab2"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8d02873-0c4a-4205-816a-57d6831124c5"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dcac461-1b2a-40dc-9b81-f58610e85cc6"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2513b9d-ce50-402f-93b0-d9d777e76420"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9040fcf-c485-4824-9172-6f10f3dc16ec"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""AlignWithView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Internal Console"",
            ""id"": ""1aa7be4a-a738-4de7-8dce-2055085055f6"",
            ""actions"": [
                {
                    ""name"": ""Console 1"",
                    ""type"": ""Button"",
                    ""id"": ""100073ca-fc1b-4c13-98b8-7fd608c64903"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 2"",
                    ""type"": ""Button"",
                    ""id"": ""606006f6-0a98-4d39-9778-47cd3be181af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 3"",
                    ""type"": ""Button"",
                    ""id"": ""282668b5-7096-4f4d-b956-69c5931e404f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 4"",
                    ""type"": ""Button"",
                    ""id"": ""b0f27c91-4f64-4310-9484-f06b5ed99919"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75a1677a-13fc-40cf-9d16-dfbf814410e5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ab9e2f3-eeac-4bc6-b0dd-0cc6c8f6d0be"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10af15f7-59dc-47f7-8768-3753bfb92254"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe848ba9-92c1-4e9d-af54-8915259c73b9"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f0dafdc-5bef-4367-a15d-88d1ef2d9b2d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d883773-0881-4795-840b-7e47b7717d81"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30f51aa2-c400-4a2c-95b0-7d6dc5cd848c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3e94c8e-c099-469e-846e-20529a3d3581"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle External Console"",
            ""id"": ""35401837-6e86-4918-ab3e-fda62c2ff0e7"",
            ""actions"": [
                {
                    ""name"": ""Console 1"",
                    ""type"": ""Button"",
                    ""id"": ""cd0c2d46-c51b-4702-a023-c1d3e06bf3a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 2"",
                    ""type"": ""Button"",
                    ""id"": ""3dded316-ef3a-4fa6-b197-017b8762352b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 3"",
                    ""type"": ""Button"",
                    ""id"": ""f203c5a3-52aa-4ea8-af81-1e8ab3e6d059"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Console 4"",
                    ""type"": ""Button"",
                    ""id"": ""63065421-7fbc-4dae-a758-d9a8dbbaf645"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""934f45ae-0baf-4df2-8a79-3ee8812fbcf6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e18e014e-bed5-4b59-b0e5-51d539bd5c37"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41b8b27f-3022-411a-84d3-ba3f7d8f6eec"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f811f99-e5bc-4477-bd48-465ac8705163"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05eb09eb-bda1-4424-a109-5ff3422482d9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c9655fc-4f87-4e0d-8352-3c827e701de8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3042061a-1594-43a3-8e89-c40bc0e56811"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Console 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c7716e5-c911-4a0b-9991-218d7e195c0f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Console 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Attitudes"",
            ""id"": ""57e82faf-2fa2-4670-8b61-d8da12633114"",
            ""actions"": [
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""1af1ccd1-2521-4fc6-9aca-fca4cbe56285"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""e14f7a05-cd50-497d-9ae3-5e0414350547"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""8089c70b-6c33-43b7-98de-108bebb356d3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c9f68270-691f-463e-b96d-a5ae7f4fe5bc"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4d16633-ca4f-453e-90a1-b442381266fa"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""266ca61f-b926-43a9-8d2c-9bace8df8acd"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e4978cb-5d3e-4a21-bcbe-1c8cc665ebff"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d04bad16-68dd-4500-8ba2-fd5341ce422e"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2402521a-4257-45b9-87fb-585a1f8e680c"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Motors"",
            ""id"": ""0c152086-559b-4cf1-aed4-afc8d4d5b6ec"",
            ""actions"": [
                {
                    ""name"": ""Surge"",
                    ""type"": ""Value"",
                    ""id"": ""8642af82-52ef-4fba-ab8b-bfe0a877adab"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sway"",
                    ""type"": ""Value"",
                    ""id"": ""287f5a1f-14d1-4481-b39d-4a892c72ed68"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeaveUp"",
                    ""type"": ""Button"",
                    ""id"": ""e2bb2a6d-3120-4dc3-98af-e635579aa9c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeaveDown"",
                    ""type"": ""Button"",
                    ""id"": ""035fcb7f-f60a-4b81-a8e3-a28a7e3e5523"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0369c18f-a1af-4f2d-81c0-66663cd8d5c1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""760ffa42-b8b2-47be-b253-0873798c4af6"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Sway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fad51f88-32f2-408b-948d-ad8ae2c29239"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HeaveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84ea7963-00de-418e-84bc-f08b82176712"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""HeaveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75ce9674-496b-4739-ba4d-aa66f603f4ef"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HeaveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""900632f1-14d4-43ba-a2a9-45da9a91ee51"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""HeaveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a59beab-a721-4cdb-b311-624beb4a14e2"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""Surge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Vehicle Dampeners"",
            ""id"": ""e1c5dccf-b763-4411-8ed9-7bd738b15452"",
            ""actions"": [
                {
                    ""name"": ""DampenSurge"",
                    ""type"": ""Button"",
                    ""id"": ""a6731109-2221-4159-86e2-0a0b47f3a5ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DampenSway"",
                    ""type"": ""Button"",
                    ""id"": ""8ee5dea2-16e4-468c-9f5d-14fa6e926814"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DampenHeave"",
                    ""type"": ""Button"",
                    ""id"": ""2e4eaa8f-2bb0-4446-9ef5-24c8f08c67be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DampenAllMotors"",
                    ""type"": ""Button"",
                    ""id"": ""72854a7a-1556-47ec-b3ae-b40303fafaed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ec978e3-49f9-4bb9-9556-47268f231c39"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenSurge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04d1ce33-c6b8-457b-b37b-258498e91313"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""DampenSurge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87ad3692-8c3e-4f6f-9305-0668ee2c1ed0"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenSway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91f47241-1c9e-4ef5-8c4d-aa17d65b07f6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""DampenSway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d16d0579-433e-4eb0-8c27-db02fbc18198"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenHeave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6bb7b8b-2d35-4ab1-8a8a-8886c0f95ff1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""DampenHeave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4cbe652-15a9-43e7-bf34-bebb6a1db46b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DampenAllMotors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f3b7a76-c4e0-4938-9d41-4554a43fc097"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad With Keyboard"",
                    ""action"": ""DampenAllMotors"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad With Keyboard"",
            ""bindingGroup"": ""Gamepad With Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Any
        m_Any = asset.FindActionMap("Any", throwIfNotFound: true);
        m_Any_Press = m_Any.FindAction("Press", throwIfNotFound: true);
        // One Dimension
        m_OneDimension = asset.FindActionMap("One Dimension", throwIfNotFound: true);
        m_OneDimension_Positive = m_OneDimension.FindAction("Positive", throwIfNotFound: true);
        m_OneDimension_Negative = m_OneDimension.FindAction("Negative", throwIfNotFound: true);
        m_OneDimension_Confirm = m_OneDimension.FindAction("Confirm", throwIfNotFound: true);
        m_OneDimension_Cancel = m_OneDimension.FindAction("Cancel", throwIfNotFound: true);
        // Vehicle Basic
        m_VehicleBasic = asset.FindActionMap("Vehicle Basic", throwIfNotFound: true);
        m_VehicleBasic_ToggleLookMode = m_VehicleBasic.FindAction("ToggleLookMode", throwIfNotFound: true);
        m_VehicleBasic_ToggleConsole = m_VehicleBasic.FindAction("ToggleConsole", throwIfNotFound: true);
        // Vehicle Free Look
        m_VehicleFreeLook = asset.FindActionMap("Vehicle Free Look", throwIfNotFound: true);
        m_VehicleFreeLook_Center = m_VehicleFreeLook.FindAction("Center", throwIfNotFound: true);
        m_VehicleFreeLook_LookX = m_VehicleFreeLook.FindAction("LookX", throwIfNotFound: true);
        m_VehicleFreeLook_LookY = m_VehicleFreeLook.FindAction("LookY", throwIfNotFound: true);
        m_VehicleFreeLook_Roll = m_VehicleFreeLook.FindAction("Roll", throwIfNotFound: true);
        m_VehicleFreeLook_AlignWithView = m_VehicleFreeLook.FindAction("AlignWithView", throwIfNotFound: true);
        // Vehicle Internal Console
        m_VehicleInternalConsole = asset.FindActionMap("Vehicle Internal Console", throwIfNotFound: true);
        m_VehicleInternalConsole_Console1 = m_VehicleInternalConsole.FindAction("Console 1", throwIfNotFound: true);
        m_VehicleInternalConsole_Console2 = m_VehicleInternalConsole.FindAction("Console 2", throwIfNotFound: true);
        m_VehicleInternalConsole_Console3 = m_VehicleInternalConsole.FindAction("Console 3", throwIfNotFound: true);
        m_VehicleInternalConsole_Console4 = m_VehicleInternalConsole.FindAction("Console 4", throwIfNotFound: true);
        // Vehicle External Console
        m_VehicleExternalConsole = asset.FindActionMap("Vehicle External Console", throwIfNotFound: true);
        m_VehicleExternalConsole_Console1 = m_VehicleExternalConsole.FindAction("Console 1", throwIfNotFound: true);
        m_VehicleExternalConsole_Console2 = m_VehicleExternalConsole.FindAction("Console 2", throwIfNotFound: true);
        m_VehicleExternalConsole_Console3 = m_VehicleExternalConsole.FindAction("Console 3", throwIfNotFound: true);
        m_VehicleExternalConsole_Console4 = m_VehicleExternalConsole.FindAction("Console 4", throwIfNotFound: true);
        // Vehicle Attitudes
        m_VehicleAttitudes = asset.FindActionMap("Vehicle Attitudes", throwIfNotFound: true);
        m_VehicleAttitudes_Pitch = m_VehicleAttitudes.FindAction("Pitch", throwIfNotFound: true);
        m_VehicleAttitudes_Yaw = m_VehicleAttitudes.FindAction("Yaw", throwIfNotFound: true);
        m_VehicleAttitudes_Roll = m_VehicleAttitudes.FindAction("Roll", throwIfNotFound: true);
        // Vehicle Motors
        m_VehicleMotors = asset.FindActionMap("Vehicle Motors", throwIfNotFound: true);
        m_VehicleMotors_Surge = m_VehicleMotors.FindAction("Surge", throwIfNotFound: true);
        m_VehicleMotors_Sway = m_VehicleMotors.FindAction("Sway", throwIfNotFound: true);
        m_VehicleMotors_HeaveUp = m_VehicleMotors.FindAction("HeaveUp", throwIfNotFound: true);
        m_VehicleMotors_HeaveDown = m_VehicleMotors.FindAction("HeaveDown", throwIfNotFound: true);
        // Vehicle Dampeners
        m_VehicleDampeners = asset.FindActionMap("Vehicle Dampeners", throwIfNotFound: true);
        m_VehicleDampeners_DampenSurge = m_VehicleDampeners.FindAction("DampenSurge", throwIfNotFound: true);
        m_VehicleDampeners_DampenSway = m_VehicleDampeners.FindAction("DampenSway", throwIfNotFound: true);
        m_VehicleDampeners_DampenHeave = m_VehicleDampeners.FindAction("DampenHeave", throwIfNotFound: true);
        m_VehicleDampeners_DampenAllMotors = m_VehicleDampeners.FindAction("DampenAllMotors", throwIfNotFound: true);
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

    // Any
    private readonly InputActionMap m_Any;
    private IAnyActions m_AnyActionsCallbackInterface;
    private readonly InputAction m_Any_Press;
    public struct AnyActions
    {
        private @InputActions m_Wrapper;
        public AnyActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Press => m_Wrapper.m_Any_Press;
        public InputActionMap Get() { return m_Wrapper.m_Any; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AnyActions set) { return set.Get(); }
        public void SetCallbacks(IAnyActions instance)
        {
            if (m_Wrapper.m_AnyActionsCallbackInterface != null)
            {
                @Press.started -= m_Wrapper.m_AnyActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_AnyActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_AnyActionsCallbackInterface.OnPress;
            }
            m_Wrapper.m_AnyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
            }
        }
    }
    public AnyActions @Any => new AnyActions(this);

    // One Dimension
    private readonly InputActionMap m_OneDimension;
    private IOneDimensionActions m_OneDimensionActionsCallbackInterface;
    private readonly InputAction m_OneDimension_Positive;
    private readonly InputAction m_OneDimension_Negative;
    private readonly InputAction m_OneDimension_Confirm;
    private readonly InputAction m_OneDimension_Cancel;
    public struct OneDimensionActions
    {
        private @InputActions m_Wrapper;
        public OneDimensionActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Positive => m_Wrapper.m_OneDimension_Positive;
        public InputAction @Negative => m_Wrapper.m_OneDimension_Negative;
        public InputAction @Confirm => m_Wrapper.m_OneDimension_Confirm;
        public InputAction @Cancel => m_Wrapper.m_OneDimension_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_OneDimension; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OneDimensionActions set) { return set.Get(); }
        public void SetCallbacks(IOneDimensionActions instance)
        {
            if (m_Wrapper.m_OneDimensionActionsCallbackInterface != null)
            {
                @Positive.started -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnPositive;
                @Positive.performed -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnPositive;
                @Positive.canceled -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnPositive;
                @Negative.started -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnNegative;
                @Negative.performed -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnNegative;
                @Negative.canceled -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnNegative;
                @Confirm.started -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_OneDimensionActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_OneDimensionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Positive.started += instance.OnPositive;
                @Positive.performed += instance.OnPositive;
                @Positive.canceled += instance.OnPositive;
                @Negative.started += instance.OnNegative;
                @Negative.performed += instance.OnNegative;
                @Negative.canceled += instance.OnNegative;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public OneDimensionActions @OneDimension => new OneDimensionActions(this);

    // Vehicle Basic
    private readonly InputActionMap m_VehicleBasic;
    private IVehicleBasicActions m_VehicleBasicActionsCallbackInterface;
    private readonly InputAction m_VehicleBasic_ToggleLookMode;
    private readonly InputAction m_VehicleBasic_ToggleConsole;
    public struct VehicleBasicActions
    {
        private @InputActions m_Wrapper;
        public VehicleBasicActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleLookMode => m_Wrapper.m_VehicleBasic_ToggleLookMode;
        public InputAction @ToggleConsole => m_Wrapper.m_VehicleBasic_ToggleConsole;
        public InputActionMap Get() { return m_Wrapper.m_VehicleBasic; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleBasicActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleBasicActions instance)
        {
            if (m_Wrapper.m_VehicleBasicActionsCallbackInterface != null)
            {
                @ToggleLookMode.started -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleLookMode;
                @ToggleLookMode.performed -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleLookMode;
                @ToggleLookMode.canceled -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleLookMode;
                @ToggleConsole.started -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleConsole;
                @ToggleConsole.performed -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleConsole;
                @ToggleConsole.canceled -= m_Wrapper.m_VehicleBasicActionsCallbackInterface.OnToggleConsole;
            }
            m_Wrapper.m_VehicleBasicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleLookMode.started += instance.OnToggleLookMode;
                @ToggleLookMode.performed += instance.OnToggleLookMode;
                @ToggleLookMode.canceled += instance.OnToggleLookMode;
                @ToggleConsole.started += instance.OnToggleConsole;
                @ToggleConsole.performed += instance.OnToggleConsole;
                @ToggleConsole.canceled += instance.OnToggleConsole;
            }
        }
    }
    public VehicleBasicActions @VehicleBasic => new VehicleBasicActions(this);

    // Vehicle Free Look
    private readonly InputActionMap m_VehicleFreeLook;
    private IVehicleFreeLookActions m_VehicleFreeLookActionsCallbackInterface;
    private readonly InputAction m_VehicleFreeLook_Center;
    private readonly InputAction m_VehicleFreeLook_LookX;
    private readonly InputAction m_VehicleFreeLook_LookY;
    private readonly InputAction m_VehicleFreeLook_Roll;
    private readonly InputAction m_VehicleFreeLook_AlignWithView;
    public struct VehicleFreeLookActions
    {
        private @InputActions m_Wrapper;
        public VehicleFreeLookActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Center => m_Wrapper.m_VehicleFreeLook_Center;
        public InputAction @LookX => m_Wrapper.m_VehicleFreeLook_LookX;
        public InputAction @LookY => m_Wrapper.m_VehicleFreeLook_LookY;
        public InputAction @Roll => m_Wrapper.m_VehicleFreeLook_Roll;
        public InputAction @AlignWithView => m_Wrapper.m_VehicleFreeLook_AlignWithView;
        public InputActionMap Get() { return m_Wrapper.m_VehicleFreeLook; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleFreeLookActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleFreeLookActions instance)
        {
            if (m_Wrapper.m_VehicleFreeLookActionsCallbackInterface != null)
            {
                @Center.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnCenter;
                @Center.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnCenter;
                @Center.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnCenter;
                @LookX.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookX;
                @LookX.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookX;
                @LookX.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookX;
                @LookY.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookY;
                @LookY.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookY;
                @LookY.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnLookY;
                @Roll.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnRoll;
                @AlignWithView.started -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnAlignWithView;
                @AlignWithView.performed -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnAlignWithView;
                @AlignWithView.canceled -= m_Wrapper.m_VehicleFreeLookActionsCallbackInterface.OnAlignWithView;
            }
            m_Wrapper.m_VehicleFreeLookActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Center.started += instance.OnCenter;
                @Center.performed += instance.OnCenter;
                @Center.canceled += instance.OnCenter;
                @LookX.started += instance.OnLookX;
                @LookX.performed += instance.OnLookX;
                @LookX.canceled += instance.OnLookX;
                @LookY.started += instance.OnLookY;
                @LookY.performed += instance.OnLookY;
                @LookY.canceled += instance.OnLookY;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @AlignWithView.started += instance.OnAlignWithView;
                @AlignWithView.performed += instance.OnAlignWithView;
                @AlignWithView.canceled += instance.OnAlignWithView;
            }
        }
    }
    public VehicleFreeLookActions @VehicleFreeLook => new VehicleFreeLookActions(this);

    // Vehicle Internal Console
    private readonly InputActionMap m_VehicleInternalConsole;
    private IVehicleInternalConsoleActions m_VehicleInternalConsoleActionsCallbackInterface;
    private readonly InputAction m_VehicleInternalConsole_Console1;
    private readonly InputAction m_VehicleInternalConsole_Console2;
    private readonly InputAction m_VehicleInternalConsole_Console3;
    private readonly InputAction m_VehicleInternalConsole_Console4;
    public struct VehicleInternalConsoleActions
    {
        private @InputActions m_Wrapper;
        public VehicleInternalConsoleActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Console1 => m_Wrapper.m_VehicleInternalConsole_Console1;
        public InputAction @Console2 => m_Wrapper.m_VehicleInternalConsole_Console2;
        public InputAction @Console3 => m_Wrapper.m_VehicleInternalConsole_Console3;
        public InputAction @Console4 => m_Wrapper.m_VehicleInternalConsole_Console4;
        public InputActionMap Get() { return m_Wrapper.m_VehicleInternalConsole; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleInternalConsoleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleInternalConsoleActions instance)
        {
            if (m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface != null)
            {
                @Console1.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole1;
                @Console2.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole2;
                @Console3.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole3;
                @Console4.started -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.performed -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.canceled -= m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface.OnConsole4;
            }
            m_Wrapper.m_VehicleInternalConsoleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Console1.started += instance.OnConsole1;
                @Console1.performed += instance.OnConsole1;
                @Console1.canceled += instance.OnConsole1;
                @Console2.started += instance.OnConsole2;
                @Console2.performed += instance.OnConsole2;
                @Console2.canceled += instance.OnConsole2;
                @Console3.started += instance.OnConsole3;
                @Console3.performed += instance.OnConsole3;
                @Console3.canceled += instance.OnConsole3;
                @Console4.started += instance.OnConsole4;
                @Console4.performed += instance.OnConsole4;
                @Console4.canceled += instance.OnConsole4;
            }
        }
    }
    public VehicleInternalConsoleActions @VehicleInternalConsole => new VehicleInternalConsoleActions(this);

    // Vehicle External Console
    private readonly InputActionMap m_VehicleExternalConsole;
    private IVehicleExternalConsoleActions m_VehicleExternalConsoleActionsCallbackInterface;
    private readonly InputAction m_VehicleExternalConsole_Console1;
    private readonly InputAction m_VehicleExternalConsole_Console2;
    private readonly InputAction m_VehicleExternalConsole_Console3;
    private readonly InputAction m_VehicleExternalConsole_Console4;
    public struct VehicleExternalConsoleActions
    {
        private @InputActions m_Wrapper;
        public VehicleExternalConsoleActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Console1 => m_Wrapper.m_VehicleExternalConsole_Console1;
        public InputAction @Console2 => m_Wrapper.m_VehicleExternalConsole_Console2;
        public InputAction @Console3 => m_Wrapper.m_VehicleExternalConsole_Console3;
        public InputAction @Console4 => m_Wrapper.m_VehicleExternalConsole_Console4;
        public InputActionMap Get() { return m_Wrapper.m_VehicleExternalConsole; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleExternalConsoleActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleExternalConsoleActions instance)
        {
            if (m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface != null)
            {
                @Console1.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole1;
                @Console1.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole1;
                @Console2.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole2;
                @Console2.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole2;
                @Console3.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole3;
                @Console3.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole3;
                @Console4.started -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.performed -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole4;
                @Console4.canceled -= m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface.OnConsole4;
            }
            m_Wrapper.m_VehicleExternalConsoleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Console1.started += instance.OnConsole1;
                @Console1.performed += instance.OnConsole1;
                @Console1.canceled += instance.OnConsole1;
                @Console2.started += instance.OnConsole2;
                @Console2.performed += instance.OnConsole2;
                @Console2.canceled += instance.OnConsole2;
                @Console3.started += instance.OnConsole3;
                @Console3.performed += instance.OnConsole3;
                @Console3.canceled += instance.OnConsole3;
                @Console4.started += instance.OnConsole4;
                @Console4.performed += instance.OnConsole4;
                @Console4.canceled += instance.OnConsole4;
            }
        }
    }
    public VehicleExternalConsoleActions @VehicleExternalConsole => new VehicleExternalConsoleActions(this);

    // Vehicle Attitudes
    private readonly InputActionMap m_VehicleAttitudes;
    private IVehicleAttitudesActions m_VehicleAttitudesActionsCallbackInterface;
    private readonly InputAction m_VehicleAttitudes_Pitch;
    private readonly InputAction m_VehicleAttitudes_Yaw;
    private readonly InputAction m_VehicleAttitudes_Roll;
    public struct VehicleAttitudesActions
    {
        private @InputActions m_Wrapper;
        public VehicleAttitudesActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pitch => m_Wrapper.m_VehicleAttitudes_Pitch;
        public InputAction @Yaw => m_Wrapper.m_VehicleAttitudes_Yaw;
        public InputAction @Roll => m_Wrapper.m_VehicleAttitudes_Roll;
        public InputActionMap Get() { return m_Wrapper.m_VehicleAttitudes; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleAttitudesActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleAttitudesActions instance)
        {
            if (m_Wrapper.m_VehicleAttitudesActionsCallbackInterface != null)
            {
                @Pitch.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnPitch;
                @Yaw.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnYaw;
                @Roll.started -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_VehicleAttitudesActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_VehicleAttitudesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
            }
        }
    }
    public VehicleAttitudesActions @VehicleAttitudes => new VehicleAttitudesActions(this);

    // Vehicle Motors
    private readonly InputActionMap m_VehicleMotors;
    private IVehicleMotorsActions m_VehicleMotorsActionsCallbackInterface;
    private readonly InputAction m_VehicleMotors_Surge;
    private readonly InputAction m_VehicleMotors_Sway;
    private readonly InputAction m_VehicleMotors_HeaveUp;
    private readonly InputAction m_VehicleMotors_HeaveDown;
    public struct VehicleMotorsActions
    {
        private @InputActions m_Wrapper;
        public VehicleMotorsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Surge => m_Wrapper.m_VehicleMotors_Surge;
        public InputAction @Sway => m_Wrapper.m_VehicleMotors_Sway;
        public InputAction @HeaveUp => m_Wrapper.m_VehicleMotors_HeaveUp;
        public InputAction @HeaveDown => m_Wrapper.m_VehicleMotors_HeaveDown;
        public InputActionMap Get() { return m_Wrapper.m_VehicleMotors; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleMotorsActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleMotorsActions instance)
        {
            if (m_Wrapper.m_VehicleMotorsActionsCallbackInterface != null)
            {
                @Surge.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurge;
                @Surge.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurge;
                @Surge.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSurge;
                @Sway.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSway;
                @Sway.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSway;
                @Sway.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnSway;
                @HeaveUp.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveUp;
                @HeaveUp.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveUp;
                @HeaveUp.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveUp;
                @HeaveDown.started -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveDown;
                @HeaveDown.performed -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveDown;
                @HeaveDown.canceled -= m_Wrapper.m_VehicleMotorsActionsCallbackInterface.OnHeaveDown;
            }
            m_Wrapper.m_VehicleMotorsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Surge.started += instance.OnSurge;
                @Surge.performed += instance.OnSurge;
                @Surge.canceled += instance.OnSurge;
                @Sway.started += instance.OnSway;
                @Sway.performed += instance.OnSway;
                @Sway.canceled += instance.OnSway;
                @HeaveUp.started += instance.OnHeaveUp;
                @HeaveUp.performed += instance.OnHeaveUp;
                @HeaveUp.canceled += instance.OnHeaveUp;
                @HeaveDown.started += instance.OnHeaveDown;
                @HeaveDown.performed += instance.OnHeaveDown;
                @HeaveDown.canceled += instance.OnHeaveDown;
            }
        }
    }
    public VehicleMotorsActions @VehicleMotors => new VehicleMotorsActions(this);

    // Vehicle Dampeners
    private readonly InputActionMap m_VehicleDampeners;
    private IVehicleDampenersActions m_VehicleDampenersActionsCallbackInterface;
    private readonly InputAction m_VehicleDampeners_DampenSurge;
    private readonly InputAction m_VehicleDampeners_DampenSway;
    private readonly InputAction m_VehicleDampeners_DampenHeave;
    private readonly InputAction m_VehicleDampeners_DampenAllMotors;
    public struct VehicleDampenersActions
    {
        private @InputActions m_Wrapper;
        public VehicleDampenersActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @DampenSurge => m_Wrapper.m_VehicleDampeners_DampenSurge;
        public InputAction @DampenSway => m_Wrapper.m_VehicleDampeners_DampenSway;
        public InputAction @DampenHeave => m_Wrapper.m_VehicleDampeners_DampenHeave;
        public InputAction @DampenAllMotors => m_Wrapper.m_VehicleDampeners_DampenAllMotors;
        public InputActionMap Get() { return m_Wrapper.m_VehicleDampeners; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleDampenersActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleDampenersActions instance)
        {
            if (m_Wrapper.m_VehicleDampenersActionsCallbackInterface != null)
            {
                @DampenSurge.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSurge;
                @DampenSurge.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSurge;
                @DampenSurge.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSurge;
                @DampenSway.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSway;
                @DampenSway.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSway;
                @DampenSway.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenSway;
                @DampenHeave.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenHeave;
                @DampenHeave.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenHeave;
                @DampenHeave.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenHeave;
                @DampenAllMotors.started -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenAllMotors;
                @DampenAllMotors.performed -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenAllMotors;
                @DampenAllMotors.canceled -= m_Wrapper.m_VehicleDampenersActionsCallbackInterface.OnDampenAllMotors;
            }
            m_Wrapper.m_VehicleDampenersActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DampenSurge.started += instance.OnDampenSurge;
                @DampenSurge.performed += instance.OnDampenSurge;
                @DampenSurge.canceled += instance.OnDampenSurge;
                @DampenSway.started += instance.OnDampenSway;
                @DampenSway.performed += instance.OnDampenSway;
                @DampenSway.canceled += instance.OnDampenSway;
                @DampenHeave.started += instance.OnDampenHeave;
                @DampenHeave.performed += instance.OnDampenHeave;
                @DampenHeave.canceled += instance.OnDampenHeave;
                @DampenAllMotors.started += instance.OnDampenAllMotors;
                @DampenAllMotors.performed += instance.OnDampenAllMotors;
                @DampenAllMotors.canceled += instance.OnDampenAllMotors;
            }
        }
    }
    public VehicleDampenersActions @VehicleDampeners => new VehicleDampenersActions(this);
    private int m_GamepadWithKeyboardSchemeIndex = -1;
    public InputControlScheme GamepadWithKeyboardScheme
    {
        get
        {
            if (m_GamepadWithKeyboardSchemeIndex == -1) m_GamepadWithKeyboardSchemeIndex = asset.FindControlSchemeIndex("Gamepad With Keyboard");
            return asset.controlSchemes[m_GamepadWithKeyboardSchemeIndex];
        }
    }
    public interface IAnyActions
    {
        void OnPress(InputAction.CallbackContext context);
    }
    public interface IOneDimensionActions
    {
        void OnPositive(InputAction.CallbackContext context);
        void OnNegative(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IVehicleBasicActions
    {
        void OnToggleLookMode(InputAction.CallbackContext context);
        void OnToggleConsole(InputAction.CallbackContext context);
    }
    public interface IVehicleFreeLookActions
    {
        void OnCenter(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnAlignWithView(InputAction.CallbackContext context);
    }
    public interface IVehicleInternalConsoleActions
    {
        void OnConsole1(InputAction.CallbackContext context);
        void OnConsole2(InputAction.CallbackContext context);
        void OnConsole3(InputAction.CallbackContext context);
        void OnConsole4(InputAction.CallbackContext context);
    }
    public interface IVehicleExternalConsoleActions
    {
        void OnConsole1(InputAction.CallbackContext context);
        void OnConsole2(InputAction.CallbackContext context);
        void OnConsole3(InputAction.CallbackContext context);
        void OnConsole4(InputAction.CallbackContext context);
    }
    public interface IVehicleAttitudesActions
    {
        void OnPitch(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
    public interface IVehicleMotorsActions
    {
        void OnSurge(InputAction.CallbackContext context);
        void OnSway(InputAction.CallbackContext context);
        void OnHeaveUp(InputAction.CallbackContext context);
        void OnHeaveDown(InputAction.CallbackContext context);
    }
    public interface IVehicleDampenersActions
    {
        void OnDampenSurge(InputAction.CallbackContext context);
        void OnDampenSway(InputAction.CallbackContext context);
        void OnDampenHeave(InputAction.CallbackContext context);
        void OnDampenAllMotors(InputAction.CallbackContext context);
    }
}
