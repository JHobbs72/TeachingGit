/*
 * Author: Jacob Hobbs - 190161842
 * Date : July 2022
 */

using TMPro;
using UnityEngine;

public class outputText : MonoBehaviour
{
    // Adds output from system to user's 'display'

    private TextMeshProUGUI _output;
    private prompt _prompt;

    void Start()
    {
        _output = GetComponent<TextMeshProUGUI>();
        _prompt = FindObjectOfType<prompt>();
    }

    public void AddOutput(string command, string content, bool flag)
    {
        if (content.Length == 0 && !flag)
        {
            _output.text += "\n>> " + command;
        }
        else if (content.Length > 0 && !flag)
        {
            _output.text += "\n>> " + command + "\n" + content;
        }
        else if (flag)
        {
            _output.text += "\n>> " + content;
        }
        
        _prompt.UpdatePrompt();
    }
    
    public void SpecialOutput(string content)
    {
        _output.text += content;
    }

    public void EmptyOut()
    {
        _output.text += "\n>>";
    }
}
