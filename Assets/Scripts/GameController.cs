using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Okbutton;
    public InputField answerField;
    void Start()
    {
        print("Hello World");
    }
    public void PrintAnswer ()
    {
        print(answerField.text);
    }
  

    // Update is called once per frame
    void Update()
    {
       
    }
}
