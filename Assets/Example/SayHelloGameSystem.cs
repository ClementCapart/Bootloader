using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayHelloGameSystem : GameSystem
{
	public string m_TextToDisplay = "Hello, world!";
	private string m_ActualTextToDisplay = "";

	public override void Init()
	{
		m_ActualTextToDisplay = m_TextToDisplay;
	}

	public override void RecoverAfterRecompile()
	{
		// - To recover things you couldn't serialize,
		// - That is a silly example but...!
		m_ActualTextToDisplay = m_TextToDisplay;
	}

	public override void Update()
	{
		Debug.Log(m_ActualTextToDisplay);
	}
}
