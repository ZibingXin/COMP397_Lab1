using UnityEngine;

namespace Platformer397
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputReader input;

        private void Start()
        {
            Debug.Log("[Start]");
            input.EnablePlayerActions();
        }

        private void OnEnable()
        {
            input.Move += GetMovement;
        }

        private void OnDisable()
        {
            input.Move -= GetMovement;
        }

        private void GetMovement(Vector2 move)
        {
            Debug.Log("[GetMovement] " + move);
        }
    }
}
