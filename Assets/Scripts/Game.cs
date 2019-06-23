using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	State state;

	void Start ()
    {
		state = startingState;
		textComponent.text = state.GetStateStory();
	}
	
	void Update ()
    {
		ManageState();
	}

	private void ManageState ()
    {
		var nextStates = state.GetNextStates();

        for (int idx = 0; idx < nextStates.Length; idx++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + idx))
            {
                state = nextStates[idx];
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                Start();
            }
        }

		textComponent.text = state.GetStateStory();
	}
}
