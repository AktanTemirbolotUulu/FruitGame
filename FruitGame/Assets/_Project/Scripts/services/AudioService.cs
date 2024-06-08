using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Project.Services
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioService : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioPlayer;
        [SerializeField] private List<AudioClass> _audios;

        private void Start()
        {
            PlayAudio("Music");
        }
        public void PlayAudio(string audioName)
        {
            foreach (AudioClass audio in _audios)
            {
                if (audio.name == audioName)
                {
                    _audioPlayer.clip = audio.clip;
                    _audioPlayer.Play();
                    break;
                }
            }   
        }
    }
    [Serializable]
    public class AudioClass
        {
            public string name;
            public AudioClip clip;
        }
}
