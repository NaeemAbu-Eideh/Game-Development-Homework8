using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    void Start()
    {
        string[] list = { "Cat", "Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};
        int i = 0;
        while (i < 7) {
            System.Random random = new System.Random();
            int x = random.Next(list.Length);
            Debug.Log("list[random] = " + (list[x]));

            i++;
        }
    }


}
