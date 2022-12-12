using UnityEngine;

namespace Game.Scripts.Collectables
{
    public class CollectableRotator : MonoBehaviour
    {
        [SerializeField] private Vector3 _rotationDirection;
        [SerializeField] private float _rotationSpeed;

        private void Update()
        {
            transform.Rotate(_rotationDirection * (_rotationSpeed * Time.deltaTime), Space.Self);
        }
    }
}