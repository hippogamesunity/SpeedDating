using System;
using Assets.Scripts.Common;
using UnityEngine;

public class TweenPanel : MonoBehaviour
{
	public TweenDirection TweenDirection;
    public bool UseCustomTweenPosition;
    public Vector3 CustomTweenPosition;
    public float DefaultTimeout = 0.4f;

    public bool Displayed
    {
        get { return transform.localPosition == Vector3.zero; }
    }

    public void Show()
    {
        Tween(true, DefaultTimeout, TweenDirection);
    }

    public void Show(float timeout)
    {
        Tween(true, timeout, TweenDirection);
    }

    public void Show(TweenDirection direction)
    {
        Tween(true, DefaultTimeout, direction);
    }

    public void Hide()
    {
        Tween(false, DefaultTimeout, TweenDirection);
    }

    public void Hide(float timeout)
    {
        Tween(false, timeout, TweenDirection);
    }

    public void Hide(TweenDirection direction)
    {
        Tween(false, DefaultTimeout, direction);
    }
    
    public void Hide(TweenDirection direction, float timeout)
    {
        Tween(false, timeout, direction);
    }

    private void Tween(bool show, float timeout, TweenDirection tweenDirection)
    {
        Vector3 vector;

        if (show)
        {
            vector = Vector3.zero;
        }
        else
        {
            if (UseCustomTweenPosition)
            {
                vector = new Vector2(CustomTweenPosition.x * transform.localScale.x, CustomTweenPosition.y * transform.localScale.y);
            }
            else
            {
                vector = GetVector(tweenDirection, 1000 * Camera.main.aspect);
            }
        }

        if (Math.Abs(timeout - 0) < 0.001f)
        {
            transform.localPosition = vector;
        }
        else
        {
            var tweenPosition = GetComponent<TweenPosition>();

            if (tweenPosition != null)
            {
                var animationCurve = tweenPosition.animationCurve;

                TweenPosition.Begin(gameObject, timeout, vector).animationCurve = animationCurve;
            }
            else
            {
                TweenPosition.Begin(gameObject, timeout, vector);
            }
        }

        TweenAlpha.Begin(gameObject, timeout / 2, show ? 1 : 0);
        TaskScheduler.CreateTask(() => gameObject.SetActive(show), show ? 0 : timeout);
    }

    private static Vector3 GetVector(TweenDirection tweenDirection, float aspect)
    {
        switch (tweenDirection)
        {
            case TweenDirection.Left:
                return -Vector2.right * aspect;
            case TweenDirection.Right:
                return Vector2.right * aspect;
            case TweenDirection.Up:
                return Vector2.up*1000;
            case TweenDirection.Down:
                return -Vector2.up*1000;
            default:
                throw new Exception();
        }
    }
}

public enum TweenDirection { Left, Right, Up, Down }