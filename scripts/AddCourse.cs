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
    [SerializeField] private Transform _downPanel;
    
    public void OnClick()
    {
        try
        {
            ISwap.SlideGet(_slide);
            ISwap.SlideDel(_slideToDown);
            
            ISwap.SlideGet(_downPanel);
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
