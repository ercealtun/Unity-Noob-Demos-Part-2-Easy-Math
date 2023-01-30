using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text firstNumber, secondNumber, operationSign, result, status;
    public InputField resultText;

    private int number1, number2, operationSignNumber; // operationSignNumber is depend on between 1-4 for the operands +,-,x,/

    private int resultNumber;
    // Start is called before the first frame update
    void Start()
    {
        NewQuestion();
    }   

    // Update is called once per frame
    void Update()
    {
    
    }

    public void ResultControl()
    {
        status.text = int.Parse(result.text) == resultNumber ? "TRUE :)" : "FALSE :(";
    }

    public void NewQuestion()
    {
        status.text = "";
        resultText.text = "";
        number1 = Random.Range(1, 11);
        number2 = Random.Range(1, 11);
        operationSignNumber = Random.Range(1, 5);

        switch (operationSignNumber)
        {
            case 1:
                operationSign.text = "+";
                resultNumber = number1 + number2;
                break;
            case 2:
                operationSign.text = "-";
                resultNumber = number1 - number2;
                break;
            case 3:
                operationSign.text = "x";
                resultNumber = number1 * number2;
                break;
            case 4:
                operationSign.text = "/";
                resultNumber = number1 / number2;
                break;
        }

        firstNumber.text = number1.ToString();
        secondNumber.text = number2.ToString();
    }
}
