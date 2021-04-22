using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //use this for initialization
    void Start()
    {
        //配列を初期化する
        int[] points = { 1, 2, 3, 4, 5 };

        //配列の要素を表示する
        for (int i = 0; i < 5; i++)
        
        {
          Debug.Log(points[i]);
        }

        


         //配列の要素を逆順にする
         for (int a = 4; a > -1; a--)

         {
           Debug.Log(points[a]);
         }


    }
    

    //update is called once per frame void update()
    void Update()
    {
        
    }
}

