using System.Text;
using UnityEngine;

public class DebugConsole : MonoBehaviour
{
    public Rect ButtonRect = new Rect(0, 0, 200, 80);
    public Rect PosRect = new Rect(0, 80, 1000, 1000);
    public Rect ViewRect = new Rect(0, 0, 1000, 1000);
    public bool Show = true;
    public bool Expand = false;
    public bool ShowOutput = true;
    public bool ShowStack = true;

    private Vector2 _scrollPos;
    private int _count;
    private readonly StringBuilder _stringBuilder = new StringBuilder();

    public void Awake()
    {
        Application.RegisterLogCallback(HandleLog);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            Expand = !Expand;
        }
    }

    public void Ding()
    {
        if (++_count > 20)
        {
            _count = 0;
            Show = !Show;
        }
    }

    public void HandleLog(string message, string stackTrace, LogType type)
    {
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

    public void OnGUI()
    {
        if (!Show) return;

        if (GUI.Button(ButtonRect, "Console"))
        {
            Expand = !Expand;
        }

        if (Expand)
        {
            _scrollPos = GUI.BeginScrollView(PosRect, _scrollPos, ViewRect);
            GUI.TextArea(new Rect(0, 0, ViewRect.width - 50, ViewRect.height), _stringBuilder.ToString());
            GUI.EndScrollView();
        }
    }
}