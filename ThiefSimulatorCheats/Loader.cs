using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System.Collections;

namespace ThiefSimulatorCheats
{
    public class Loader : MonoBehaviour
    {
        public static void Init()
        {
            Loader._Load = new GameObject();
            Loader._Load.AddComponent<Cheats>();
            Loader._Load.AddComponent<Menu>();
            Loader.DontDestroyOnLoad(Loader._Load);
        }
        private static GameObject _Load;
    }
}
