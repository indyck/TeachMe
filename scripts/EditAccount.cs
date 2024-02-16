using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EditAccount : MonoBehaviour,ISwap
{
    [SerializeField] private InputField[] _inputFields;
    [SerializeField] private Transform _slide;
    [SerializeField] private Transform[] _slideToDown;
    public void OnClick()
    {
        for (int i = 0; i < _inputFields.Length; i++)
        {
            if (_inputFields[i].text == "")
            {
                continue;
            }
            switch (i)
            {
                case 0:
                    {
                        RegisterScript.Name = _inputFields[0].text;
                        break;
                    }
                case 1:
                    {
                        RegisterScript.Surname = _inputFields[1].text;
                        break;
                    }
                case 2:
                    {
                        RegisterScript.Password = _inputFields[2].text;
                        break;
                    }
            }
        }
        ISwap.SlideGet(_slide);
        ISwap.SwapDown(_slideToDown);
        Account._isClicked = false;
        Debug.Log(RegisterScript.Name + RegisterScript.Surname + RegisterScript.Password);
    }
}
