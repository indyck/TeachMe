using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackFromAdmin : MonoBehaviour,ISwap
{
    [SerializeField] private Transform[] _slides;
    [SerializeField]private GameObject _content;
    GameObject _newgo;
    public void OnClick()
    {
        if (YouAreStudent.IsTeacher)
        {
            ISwap.SlideGet(_slides[0]);
            
        }
        else
        {
            ISwap.SlideGet(_slides[1]);
        }
        ISwap.SlideDel(_slides[2]);
        _newgo = new GameObject("Nigga");
        _newgo.transform.parent = this.gameObject.transform;
    }
}
