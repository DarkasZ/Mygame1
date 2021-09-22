using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Okbutton;
    public InputField answerField;
    public Text displayText;
    public Button Resetbutton;
    string[] answers;
    string[] questions01;
    string[] questions02;
    string[] questions03;
    int CurrentQuestionNumber = 0;
    void Start()
    {
        answers = new string[3];
        questions01 = new string[] {"What is your name?","What is your Nickname","What is your favorite charater name" };
        questions02 = new string[] { "What is your fav food?", "What is your fav dessert?", "What is your fav beverage?" };
        questions03 = new string[] { "What is your fav song from Japan?", "What is your fav song from Thailand?", "What is your fav song from Korea?" };


        displayText.text = questions01[Random.Range(0,questions01.Length)];

        Resetbutton.gameObject.SetActive(false);
    }
    public void PrintAnswer ()
    {
        answers[CurrentQuestionNumber] = answerField.text;
        answerField.text = "";

        CurrentQuestionNumber += 1;
        if (CurrentQuestionNumber <= 2)
        {
            if(CurrentQuestionNumber == 0)
            {
                string RandomName01 = questions01[Random.Range(0, questions01.Length)];
                displayText.text = RandomName01;
            }
            else if(CurrentQuestionNumber == 1)
            {
                string RandomName02 = questions02[Random.Range(0, questions02.Length)];
                displayText.text = RandomName02;
            }
            else if(CurrentQuestionNumber == 2)
            {
                string RandomName03 = questions03[Random.Range(0, questions03.Length)];
                displayText.text = RandomName03;
            }
        }
        else
        {
            displayText.text = (answers[0] + " like to eat " + answers[1] + " and like to sing  " + answers[2]);

            Okbutton.gameObject.SetActive(false);
            answerField.gameObject.SetActive(false);
            Resetbutton.gameObject.SetActive(true);
        }

    }
    public void Restartbutton()
    {
        SceneManager.LoadScene("StoryGame");
    }
    

    // Update is called once per frame
    void Update()
    {
       
    }
}
