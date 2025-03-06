using UnityEngine;

namespace Platformer397
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioController : MonoBehaviour
    {
        [SerializeField] private AudioAsset menuMusic;
        [SerializeField] private AudioSource menuMusicSource;

        private void Start()
        {
            menuMusicSource = GetComponent<AudioSource>();
            menuMusicSource.clip = menuMusic.audioClip;
            menuMusicSource.volume = menuMusic.audioVolume;
            menuMusicSource.loop = menuMusic.audioLooping;
            menuMusicSource.Play();
        }
    }
}
