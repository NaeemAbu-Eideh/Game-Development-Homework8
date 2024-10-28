using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 20) {
            System.Random random = new System.Random();
            int x = random.Next(1, 20);
            if (x == 5) {
                Debug.Log("continue");
                continue;
            }
            else if (x == 15) {
                Debug.Log("exit");
                break;
            }
            else {
                Debug.Log("number is: " + (x));
            }
        }
    }


}
