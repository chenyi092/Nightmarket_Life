using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ring_left : MonoBehaviour
{
        
        public static int i = 5;

        void Update ()
        {
            GetComponent<TextMeshProUGUI>().text = "X" + i;

        }
}
