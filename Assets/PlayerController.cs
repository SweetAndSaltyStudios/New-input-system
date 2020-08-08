using UnityEngine;
using UnityEngine.InputSystem;

namespace Sweet_And_Salty_Studios
{
    public class PlayerController : MonoBehaviour
    {
        #region VARIABLES

        private Vector2 movementDiretion;
        private readonly float moveSpeed = 4f;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Update()
        {
            if(movementDiretion == Vector2.zero)
            {
                return;
            }

            Move();

        }

        private void OnDeviceLost()
        {
            Debug.LogWarning("Device Lost", gameObject);
        }

        private void OnDeviceRegained()
        {
            Debug.LogWarning("Device Regained", gameObject);
        }

        private void OnMove(InputValue value)
        {
            Debug.LogWarning("On Move", gameObject);

            movementDiretion = value.Get<Vector2>();
        }

        private void OnMoveUp()
        {
            Debug.LogWarning("On Move Up", gameObject);
            transform.Translate(Vector3.up);
        }

        private void OnMoveDown()
        {
            Debug.LogWarning("On Move Down", gameObject);
            transform.Translate(Vector3.down);
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        private void Move()
        {
            var movement = new Vector3(movementDiretion.x, 0, movementDiretion.y) * moveSpeed * Time.deltaTime;
            transform.Translate(movement);
        }

        #endregion CUSTOM_FUNCTIONS
    }
}

