using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickEnterText : MonoBehaviour
{
    [SerializeField] private Transform[] _toMove;
    [SerializeField] private Text[] _textToReplace;
    public static bool InEnter = false;
    public void OnClick()
    {
        if (InEnter)
        {
            foreach (Transform t in _toMove)
            {
                t.position -= new Vector3(20, 0);
            }
            foreach (Text i in _textToReplace)
            {
                switch (i.text)
                {
                    case "����":
                        {
                            i.text = "�����������";
                            break;
                        }
                    case "�����������":
                        {
                            i.text = "�����";
                            break;
                        }
                    case "��� ��� ��������?":
                        {
                            i.text = "���� �������?";
                            break;
                        }
                    default: break;
                }
            }
            InEnter = false;
        }
        else
        {
            foreach (Transform t in _toMove)
            {
                t.position += new Vector3(20, 0);
            }
            foreach (Text i in _textToReplace)
            {
                switch (i.text)
                {
                    case "�����������":
                        {
                            i.text = "����";
                            break;
                        }
                    case "�����":
                        {
                            i.text = "�����������";
                            break;
                        }
                    case "���� �������?":
                        {
                            i.text = "��� ��� ��������?";
                            break;
                        }
                    default: break;
                }
            }
            InEnter = true;
        }
        
    }
}
