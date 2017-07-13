using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSurroundManager : MonoBehaviour {

	
	public AudioSource m_FLeftSrc;
	public AudioSource m_FRightSrc;
	public AudioSource m_BLeftSrc;
	public AudioSource m_BRightSrc;
	public AudioSource m_CenterSrc;
	public AudioSource m_BaseSrc;
	

	public AudioClip m_FLeftClip;
	public AudioClip m_FRightClip;
	public AudioClip m_BLeftClip;
	public AudioClip m_BRightClip;
	public AudioClip m_CentreClip;
	public AudioClip m_BaseClip;

	MovieTexture m_movie;
	void Start () {

		m_FLeftSrc.clip = m_FLeftClip;
		m_FRightSrc.clip = m_FRightClip;
		m_BLeftSrc.clip = m_BLeftClip;
		m_BRightSrc.clip = m_BRightClip;
		m_BaseSrc.clip = m_BaseClip;
		m_CenterSrc.clip = m_CentreClip;
		m_movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		InvokeRepeating ("PlayMovieClip", 2,22);	
	}
	
	void PlayMovieClip(){
		m_movie.Stop();
		m_movie.Play();
		m_FLeftSrc.Play();
		m_FRightSrc.Play();
		m_BLeftSrc.Play();
		m_BRightSrc.Play();
		m_BaseSrc.Play();
		m_CenterSrc.Play();

	}
	// Update is called once per frame
	void Update () {
		
	}
}
