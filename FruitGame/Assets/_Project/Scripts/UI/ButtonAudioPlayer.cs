using System.Collections;
using System.Collections.Generic;
using Project.Services;
using UnityEngine;
using UnityEngine.UI;
namespace Ptoject.UI
{
    [RequireComponent(typeof(Button))]
public class ButtonAudioPlayer : MonoBehaviour
{
    [SerializeField] private string _audioName = "Button";
    private Button _button;
    private AudioService _audioService;
    private void Start()
    {
        _button = GetComponent<Button>();
        _audioService = FindObjectOfType<AudioService>(true);

        _button.onClick.AddListener(PlayButtonAudio);
    }

    private void PlayButtonAudio()
    {
        _audioService.PlayAudio(_audioName);
    }
}
}
