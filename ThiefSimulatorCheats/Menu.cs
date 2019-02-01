using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using System.Collections;
using UnityEngineInternal;
using UnityEngine.Rendering;
using UnityStandardAssets;

namespace ThiefSimulatorCheats
{
    public class Menu : MonoBehaviour
    {
        private void Start()
        {
            _mainWindow = new Rect(30f, 10f, 250f, 150f);
            _teleWindow = new Rect(30f, 10f, 250f, 150f);
            _playerWindow = new Rect(30f, 10f, 250f, 150f);
        }

        private void OnGUI()
        {
            if (!menuVisible)
            {
                return;
            }

            this._mainWindow = GUILayout.Window(0, this._mainWindow, new GUI.WindowFunction(DrawHome), "Sus's Main Menu", new GUILayoutOption[0]);

            if (teleVisible)
            {
                this._teleWindow = GUILayout.Window(1, this._teleWindow, new GUI.WindowFunction(DrawTeleports), "Teleport Menu", new GUILayoutOption[0]);
            }

            if (playerVisible)
            {
                this._playerWindow = GUILayout.Window(2, this._playerWindow, new GUI.WindowFunction(DrawPlayerStats), "Player Stats", new GUILayoutOption[0]);
            }
        }

        private void DrawHome(int id)
        {
            Menu.gravToggle = GUILayout.Toggle(Menu.gravToggle, "Toggles Gravity", new GUILayoutOption[0]);          

            GUILayout.Space(15f);

            if (GUILayout.Button("Opens Teleports", new GUILayoutOption[0]))
            {
                teleVisible = !teleVisible;
            }

            if (GUILayout.Button("Open Player Stats", new GUILayoutOption[0]))
            {
                playerVisible = !playerVisible;
            }

            GUI.DragWindow();
        }

        private void DrawTeleports(int id)
        {
            if (GUILayout.Button("House 101", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-70, 10, 155));
            }

            if (GUILayout.Button("House 102", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-90, 9, 139));
            }

            if(GUILayout.Button("House 103", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-89, 9, 118));
            }

            if (GUILayout.Button("House 104", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-30, 10, 99));
            }

            if (GUILayout.Button("House 105", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-21, 10, 100));
            }

            if (GUILayout.Button("House 106", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-13, 10, 101));
            }

            if (GUILayout.Button("House 107", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-52, -0.6f, 45));
            }

            if (GUILayout.Button("House 108", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-9.1f, -0.6f, 45));
            }

            if (GUILayout.Button("House 109", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(48, 0, 59));
            }

            if (GUILayout.Button("House 110", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(62, 0, 56));
            }

            if (GUILayout.Button("House 111", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(69, 0, 37));
            }

            if (GUILayout.Button("House 112", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(-20f, 9, -49f));
            }

            if (GUILayout.Button("House 113", new GUILayoutOption[0]))
            {
                vp_LocalPlayer.Teleport(new Vector3(10, 10, -50f));
            }
            GUI.DragWindow();
        }

        private void DrawPlayerStats(int id)
        {
            if(GUILayout.Button("Add $1000", new GUILayoutOption[0]))
            {
                PlayerInventory.cash += 1000;
            }

            if (GUILayout.Button("Add $5000", new GUILayoutOption[0]))
            {
                PlayerInventory.cash += 5000;
            }

            if (GUILayout.Button("Add 1 Skill Point", new GUILayoutOption[0]))
            {
                PlayerInventory.skillPoints += 1;
            }

            if (GUILayout.Button("Add 5 Skill Points", new GUILayoutOption[0]))
            {
                PlayerInventory.skillPoints += 5;
            }

            if (GUILayout.Button("Increase Level By 1", new GUILayoutOption[0]))
            {
                PlayerInventory.level += 1;
            }

            if (GUILayout.Button("Increase Level By 5", new GUILayoutOption[0]))
            {
                PlayerInventory.level += 5;
            }

            if (GUILayout.Button("Reset Stats", new GUILayoutOption[0]))
            {
                PlayerInventory.level = 1;
                PlayerInventory.cash = 1000;
                PlayerInventory.skillPoints = 0;
                PlayerInventory.experience = 0;
            }

            GUILayout.Space(15f);

            GUI.DragWindow();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Home))
            {
                menuVisible = !menuVisible;
                mouseToggle = !mouseToggle;
            }

            if (mouseToggle)
            {
                vp_LocalPlayer.ShowMouseCursor();
            } else
            {
                vp_LocalPlayer.HideMouseCursor();
            }
        }
        
        // Global Variables --
        public bool menuVisible = false;
        public bool teleVisible = false;
        public bool playerVisible = false;
        public bool mouseToggle = false;

        private Rect _mainWindow;
        private Rect _teleWindow;
        private Rect _playerWindow;

        public static bool gravToggle = false;
    }
}


    // house 101
    // -70, 10, 155

    // house 102
    // -90, 9, 139

    // house 103
    // -89, 9, 118

    // house 104
    // -30, 10, 99

    // house 105
    // - 21, 10, 100,

    // house 106
    // - 13, 10, 101
    
    // house 107
    // -52, -0.6, 45

    // house 108
    // -9.1, -0.6, 45

    // house 109
    // 48, 0, 59

    // House 110
    // 62, 0, 56

    // House 111
    // 69, 0, 37

    // house 112
    // -20, 9, -49

    // house 113
    // 10, 10, -50