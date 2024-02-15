using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddCourse : MonoBehaviour,ISwap
{
    public GameObject Content;
    public GameObject NewCourse;
    [SerializeField] private InputField _name;
    [SerializeField] private  InputField _number;
    [SerializeField] private Transform _slide;
    [SerializeField] private Transform _slideToDown;
    [SerializeField] private Font _font;
    RectTransform _rect;
    RectTransform _textRect;
    private GameObject _text;
    private Text _textText;
    public void OnClick()
    {
        try
        {
            ISwap.SlideGet(_slide);
            ISwap.SlideDel(_slideToDown);
            NewCourse = new GameObject(_name.text);
            NewCourse.transform.parent = Content.transform;
            NewCourse.transform.localPosition = new Vector3(0, 28 - (267 * (Content.transform.childCount - 1)), -17280);
            NewCourse.AddComponent<Image>();
            NewCourse.AddComponent<Button>();
            _rect = NewCourse.GetComponent<RectTransform>();
            _rect.localScale = new Vector3(9.06f, 1.92f, 1f);
            _text = new GameObject("Text");
            _text.transform.parent = NewCourse.transform;
            _text.AddComponent<Text>();
            _textText = _text.GetComponent<Text>();
            _textText.font = _font;
            _textText.color = Color.black;
            _textRect = _text.GetComponent<RectTransform>();
            _textRect.localPosition = new Vector3(0, -7.629395e-06f,0);
            _textRect.localScale = new Vector3(0.2f, 1,1);
            _textRect.sizeDelta = new Vector2(199.55f,100);
            _textText.alignment = TextAnchor.MiddleCenter;
            _textText.text = _name.text;_textText.fontSize = 40;
        }
        catch
        {
            GameObject a = transform.GetChild(0).gameObject;
            Text b = a.GetComponent<Text>();
            b.fontSize = 55;
            b.text = "Ошибка";
        }
        
        
    }
}
