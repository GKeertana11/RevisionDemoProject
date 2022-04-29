

using UnityEngine;

namespace MyNewNameSpace
{
    [System.Serializable]
    public class MyNameSpaceClass 
    {

        public int playerSpeed;
        public float playerRotation;
        public bool isAlive;
        public string name;
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


