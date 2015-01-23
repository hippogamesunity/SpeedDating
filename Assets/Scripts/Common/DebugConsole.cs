using System.Text;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class DebugConsole : Script
    {
        public bool ShowOutput = true;
        public bool ShowStack = true;
    
        public void Awake()
        {
            _stringBuilder.AppendLine("CONSOLE:");
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.BackQuote)) 
            {
                Show = !Show;
                Debug.Log("~");
            }
        }

        int _errorCount;

        readonly StringBuilder _stringBuilder = new StringBuilder();

        public void OnEnable()
        {
            Application.RegisterLogCallback(HandleLog);
        }
        public void OnDisable()
        {
            Application.RegisterLogCallback(null);
        }
    
        public void HandleLog(string message, string stackTrace, LogType type)
        {
            if (type == LogType.Exception || type == LogType.Error)
            {
                _errorCount++;
            }

            if (ShowOutput || ShowStack)
            {
                if (ShowOutput)
                {
                    _stringBuilder.AppendLine(message);
                }
            
                if (ShowStack || type == LogType.Exception || type == LogType.Error)
                {
                    _stringBuilder.AppendLine(stackTrace);
                }
            }
        }

        public Rect ButtonRect = new Rect(10, 30, 70, 20);
        public Rect PosRect = new Rect(0, 75, 400, 400);
        public Rect ViewRect = new Rect(0, 0, 400, 60000);
        Vector2 _scrollPos;
        public bool Show = false;

        public void OnGUI()
        {
            if (GUI.Button(ButtonRect, "Console"))
            {
                Show = !Show;
            }

            if (Show)
            {
                //GUI.Label(new Rect(PosRect.x, PosRect.y - 20, 200, 50), "[errors " + _errorCount + "] length: " + _stringBuilder.Length, "box");
                _scrollPos = GUI.BeginScrollView(PosRect, _scrollPos, ViewRect);
                GUI.TextArea(new Rect(0, 0, ViewRect.width - 50, ViewRect.height), _stringBuilder.ToString());
                GUI.EndScrollView();
            }
        }
    }
}