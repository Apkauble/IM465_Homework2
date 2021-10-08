using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    //TODO: Add PlayerTwoButton reference
    [SerializeField]
    private Button joinPlayerTwo;

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;

    //Variables
    private bool playerOneActive = false;
    private bool playerTwoActive = false;

    
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        //TODO Listen for player two click event
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
    }

    private void JoinPlayerOne()
    {
        playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
        
        //TODO flip text to say "Leave Player One"
        if(!playerOneActive)
        {
            joinPlayerOne.transform.GetChild(0).GetComponent<Text>().text = "Leave Player One";
            playerOneActive = true;
        }

        else
        {
            joinPlayerOne.transform.GetChild(0).GetComponent<Text>().text = "Join Player One";
            playerInputManager.LeavePlayer(0);
            playerOneActive = false;
        }

        //TODO on click after player has joined, remove player
    }

    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme
    //TODO flip text after player has joined to say "Leave Player Two"
    //TODO on click after player has joined, remove player

    private void JoinPlayerTwo()
    {
        playerInputManager.JoinPlayer(1, "PlayerTwo");

        //TODO flip text to say "Leave Player One"
        if (!playerTwoActive)
        {
            joinPlayerTwo.transform.GetChild(0).GetComponent<Text>().text = "Leave Player Two";
            playerTwoActive = true;
        }

        else
        {
            joinPlayerTwo.transform.GetChild(0).GetComponent<Text>().text = "Join Player Two";
            playerInputManager.LeavePlayer(1);
            playerTwoActive = false;
        }

        //TODO on click after player has joined, remove player
    }
}
