using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System.Collections;

using UnityEngine.SceneManagement;


namespace ThiefSimulatorCheats
{
    public class Cheats : MonoBehaviour
    {

        // -- Toggles & Variables
        public Vector3 currentPos = new Vector3();     
        //-------------------------------------------


        private void OnGUI()
        {           
            GUI.Label(new Rect(20f, 210f, 200f, 200f), "Menu Loaded - Made by Sus :)");
            GUI.Label(new Rect(20F, 240f, 200f, 200F), "[F1] Gives $1000");
            GUI.Label(new Rect(20F, 260f, 200f, 200F), "[F2] Gives 5 Skill Points");
            GUI.Label(new Rect(20F, 280f, 200f, 200F), "[F3] Levels You Up");

            GUI.Label(new Rect(25F, 733f, 300f, 200f),$"Current Coords: {currentPos}");
        }

        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.F1))
            {
                PlayerInventory.cash += 1000;
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                PlayerInventory.skillPoints += 5;
            }

            if (Input.GetKeyDown(KeyCode.F3))
            {
                PlayerInventory.level++;
            }          
  
           currentPos = vp_LocalPlayer.Position;
            // - Toggle Functions      
        }
    }
}
