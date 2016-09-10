using UnityEngine;
using System.Collections;
using System.IO.Ports;
using UnityEngine.UI;
using System.Collections.Generic;

public class ConnectSerial : MonoBehaviour {

    SerialPort stream = new SerialPort("COM3", 9600);
    public Text keyboard;
    public Text textEntry;
    public int focus = 0;
    private List<string> characters = new List<string> {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","_"};

    void Start () {
        textEntry.text = "";
        stream.Open();
        stream.ReadTimeout = 50;
    }

    void Update () {
        string value = stream.ReadLine();
        if ((value == "Enter") && (focus > 0)) {
            if (characters[focus] == "_") {
                textEntry.text = textEntry.text + " ";
            } else {
                textEntry.text = textEntry.text + characters[focus];
            }
        } else if ((value == "Delete") && (textEntry.text != "")) {
            textEntry.text = textEntry.text.Substring(0,textEntry.text.Length-1);
        } else if ((value == "Right") && (focus < 27)) {
            focus = focus + 1;
        } else if ((value == "Left") && (focus > 0)) {
            focus = focus - 1;
        } else if ((value == "Down") && (focus < 16)) {
            focus = focus + 14; 
            if (focus > 26) {
                focus = 26;
            }
        } else if ((value == "Up") && (focus > 14)) {
            focus = focus - 14;
        }
        UpdateKeyboard();
    }

    void UpdateKeyboard() {
        string newTXT = "";
        for (int i = 0; i<characters.Count; i=i+1) {
            if (i == focus) {
                newTXT = newTXT + "<color=\"#FFFFFF\">" + characters[i] + "</color> ";
            } else {
                newTXT = newTXT + characters[i] + " ";
            }
        }
        keyboard.text = newTXT.Substring(0,newTXT.Length-1);
    }

    void Debug() {
        string value = "";
        if (Input.GetKeyDown("a")) {
            value = "Left";
        } else if (Input.GetKeyDown("d")) {
            value = "Right";
        } else if (Input.GetKeyDown("w")) {
            value = "Up";
        } else if (Input.GetKeyDown("s")) {
            value = "Down";
        } else if (Input.GetKeyDown("z")) {
            value = "Delete";
        } else if (Input.GetKeyDown("x")) {
            value = "Enter";
        }
    }
}