using Models;
using UnityEngine;
using VContainer.Unity;

namespace Core
{
    public class GameManager : IStartable
    {
        private readonly GridSystem _gridSystem;

        public GameManager(GridSystem gridSystem)
        {
            _gridSystem = gridSystem;
            Debug.Log("Game Manager received GridSystem from VContainer");
        }

        public void Start()
        {
            Debug.Log("Game Manager started");
        }
    }
}