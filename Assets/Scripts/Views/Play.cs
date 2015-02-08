using System;
using Assets.Scripts.Common;
using Assets.Scripts.Logic;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Play : ViewBase
    {
        public TweenPanel PauseDialog;
        public TweenPanel ScoreDialog;
        public TweenPanel HelpDialog;
        public UILabel ScoreDialogTitle;
        public UILabel ScoreDialogMessage;
        public UILabel HelpDialogMessage;
        public Transform GameTransform;
        public UILabel Timer;
        public UITexture Background;
        public UILabel Score;
        public Transform Arrow;
        public UITexture TimeIcon;
        public UITexture SwapIcon;

        protected override void Initialize()
        {
            PauseDialog.Hide(0f);
            ScoreDialog.Hide(0f);
            HelpDialog.Hide(0f);

            Score.SetText("0/{0}", Engine.Level.Target);

            if (Engine.Level.Type == LevelType.Time)
            {
                TimeIcon.enabled = true;
                SwapIcon.enabled = false;
                Arrow.gameObject.SetActive(true);
                HelpDialogMessage.SetText("Help characters to find a soulmate\nMove them between tables");
            }
            else if (Engine.Level.Type == LevelType.Swap)
            {
                SwapIcon.enabled = true;
                TimeIcon.enabled = false;
                Arrow.gameObject.SetActive(false);
                HelpDialogMessage.SetText("You have swap limit in this mode");
            }
        }

        protected override void Cleanup()
        {
            Initialize();
        }

        public void Update()
        {
            if (Engine.State != GameState.Playing) return;

            if (Engine.Level.Type == LevelType.Time)
            {
                var timespan = Engine.Timeout - DateTime.Now;

                if (timespan.TotalSeconds > 0)
                {
                    if (Engine.State != GameState.Playing) return;

                    Timer.SetText(Convert.ToString(Math.Round(timespan.TotalSeconds)));

                    var p = (float) timespan.TotalSeconds / Engine.Level.Time;

                    Arrow.rotation = Quaternion.Euler(0, 0, 360 * p - 360);

                    if (p < 0.25)
                    {
                        var blink = (Mathf.Sin(4 * Time.time) + 1) / 2;

                        Timer.color = new Color(1, blink, blink);
                    }
                    else
                    {
                        Timer.color = Color.white;
                    }
                }
                else
                {
                    Get<Engine>().CompleteGame();
                }
            }
            else if (Engine.Level.Type == LevelType.Swap)
            {
                var swapsleft = Engine.Level.Swaps - Engine.Swaps;

                if (swapsleft >= 0)
                {
                    Timer.SetText(Convert.ToString(swapsleft));
                }
            }
        }

        public void ShowDialog(TweenPanel dialog)
        {
            dialog.Show();
        }

        public void SetScoreDialog(bool completed)
        {
            ScoreDialogTitle.SetText(completed ? "Win" : Engine.Level.Type == LevelType.Time ? "Time is up" : "Game over");
            ScoreDialogMessage.SetText(completed ? "Congratulation, level completed!" : "Better luck next time!");
        }

        public void CloseDialog()
        {
            if (PauseDialog.Displayed)
            {
                PauseDialog.Hide();
            }
            else if (HelpDialog.Displayed)
            {
                HelpDialog.Hide();
            }
            else if (ScoreDialog.Displayed)
            {
                ScoreDialog.Hide();
            }
        }

        public void RefreshScore()
        {
            Score.SetText("{0}/{1}", Convert.ToString(Engine.CalcScore()), Engine.Level.Target);
        }
    }
}