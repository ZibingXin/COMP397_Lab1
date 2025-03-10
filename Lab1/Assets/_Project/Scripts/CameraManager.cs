using Unity.Cinemachine;
using UnityEngine;

namespace Platformer397
{
    public class CameraManager : MonoBehaviour
    {
        // References to the CinemachineVirtualCamera and the Transform of our player
        [SerializeField] private CinemachineCamera freeLookCam;
        [SerializeField] private Transform player;

        // In Awake, I want to lock the mouse into the Game View in Unity and turn the cursor invisible
        private void Awake()
        {
            if (player == null)
            { 
                player = GameObject.FindWithTag("Player").transform; 
            }
            // player ??= GameObject.FindWithTag("Player").transform;

            //Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = false;
        }
        
        // On Enable, I want to associate the transform of our player into the target of your cinemachine camera

        private void OnEnable()
        {
            freeLookCam.Target.TrackingTarget = player;
        }
    }
}
