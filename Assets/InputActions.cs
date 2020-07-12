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
            ""name"": ""OneDimension"",
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
        // OneDimension
        m_OneDimension = asset.FindActionMap("OneDimension", throwIfNotFound: true);
        m_OneDimension_Positive = m_OneDimension.FindAction("Positive", throwIfNotFound: true);
        m_OneDimension_Negative = m_OneDimension.FindAction("Negative", throwIfNotFound: true);
        m_OneDimension_Confirm = m_OneDimension.FindAction("Confirm", throwIfNotFound: true);
        m_OneDimension_Cancel = m_OneDimension.FindAction("Cancel", throwIfNotFound: true);
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

    // OneDimension
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
}
