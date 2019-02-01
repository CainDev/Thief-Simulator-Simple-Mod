using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using UnityEngine.UI;
using System.Collections;

using UnityEngine.SceneManagement;


namespace ThiefSimulatorCheats
{
    public class Cheats : MonoBehaviour
    {
        private void Update()
        {
            if (Menu.gravToggle)
            {
                Physics.gravity = new Vector3(0f, 3f, 0f);
            } else
            {
                Physics.gravity = new Vector3(0f, -5f, 0f);
            }
        }
    }
}
