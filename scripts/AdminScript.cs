using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminScript : MonoBehaviour
{
    private InputField _inp;
    [SerializeField] private Text _text;
    private void Start()
    {
        _inp = GetComponent<InputField>();
    }
    public void AreYouAdmin()
    {
        if (_inp.text == "9875632140")
        {
            _inp.text = string.Empty;
            _text.text = "Теперь вы админ";
        }
        else
        {
            _inp.text = string.Empty;
            _text.text = "Неверный пароль";
        }
    }
}
