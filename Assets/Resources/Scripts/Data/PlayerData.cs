using UnityEngine;

namespace Resources.Scripts.Data
{
    [CreateAssetMenu(fileName = "Player", menuName = "Player Data")]
    public class PlayerData : ScriptableObject
    {
        [Header("Prefab")]
        [SerializeField]
        private GameObject _playerPrefab;

        [Header("Movement")]
        [SerializeField]
        private float _movementSpeed;

        [Header("Health")]
        [SerializeField]
        private float _health;

        public GameObject PlayerPrefab => _playerPrefab; 
        public float MovementSpeed => _movementSpeed;
        public float Health => _health;
    }
}