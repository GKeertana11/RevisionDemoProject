

using UnityEngine;

namespace MyNewNameSpace
{
    public class MyNameSpaceClass 
    {
        public static void MyPrint()
        {
            Debug.Log("My print method in namespace");
        }
    }
    namespace MyUI { 
        public class MyUIClass
        {
            public static void UIprint()
            {
                Debug.Log("From my UIprint method");
            }
        }
    }


}


