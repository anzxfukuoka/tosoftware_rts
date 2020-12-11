using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level
{
    public class LevelBuilder : MonoBehaviour
    {
        private static LevelBuilder _instance;

        public static LevelBuilder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<LevelBuilder>();
                }

                return _instance;
            }
        }

        public void BuildLevel(Level level)
        {

        }

    }
}

