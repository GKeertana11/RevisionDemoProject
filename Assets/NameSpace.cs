using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyNewNameSpace;
using MyNewNameSpace.MyUI;
//namespace is a keyword where we use it before particular namespace.
//Syntax:
//namespace name{}

public class NameSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyNameSpaceClass.MyPrint();
        MyUIClass.UIprint();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
