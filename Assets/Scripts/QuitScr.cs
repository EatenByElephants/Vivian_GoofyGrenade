﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScr : MonoBehaviour {

	public void QuitGame () {
        Debug.Log("Quit");
        Application.Quit();
	}
}
