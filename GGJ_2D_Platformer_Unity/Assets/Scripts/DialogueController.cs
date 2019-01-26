﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour {

  public GameObject dBox;
  public Text dText;

  public bool dialogueActive;

  // Use this for initialization
  void Start () {
    dialogueActive = true;
  }

  // Update is called once per frame
  void Update () {
    if(dialogueActive && Input.GetKeyDown(KeyCode.Space)) {
      dBox.SetActive(false);
      dialogueActive = false;
    }
  }

  public void ShowBox(string dialogue) {
    dialogueActive = true;
    dBox.SetActive(true);
    dText.text = dialogue;
  }

}
