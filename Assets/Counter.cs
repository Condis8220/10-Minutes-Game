using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int count;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = count.ToString();
    }

    public static void Add()
    {
        count++;
    }

    public static void Clear()
    {
        count = 0;
    }
}
