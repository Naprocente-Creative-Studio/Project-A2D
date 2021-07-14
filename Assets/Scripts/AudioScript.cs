using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
	public AudioClip[] audioClips;

	public void PlayExpl()
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[1]);
	}

	public void PlayShield()
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[2]);
	}

	public void PlayShieldUp()
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[3]);
	}

	public void PlayStart()
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[1]);
	}

	public void PlayMenu()
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[0]);
	}
}
