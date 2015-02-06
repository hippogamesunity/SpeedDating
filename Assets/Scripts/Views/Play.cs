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
        public Transform GameTransform;
        public UILabel Timer;
        public UITexture Background;
        public UILabel Score;
        public Transform Arrow;
        public UISprite TimeProgress;

        protected override void Initialize()
        {
            PauseDialog.Hide(0f);
            ScoreDialog.Hide(0f);
            HelpDialog.Hide(0f);

            Score.SetText("0/{0}", Engine.Level.Target);
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
                    TimeProgress.fillAmount = (float) timespan.TotalSeconds / Engine.Level.Time;
                    Arrow.rotation = Quaternion.Euler(0, 0, 360 * TimeProgress.fillAmount - 360);

                    if (TimeProgress.fillAmount < 0.25)
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
            //else
            //{
            //    var shiftsLeft = Level.Shifts - _shifts;

            //    if (shiftsLeft >= 0)
            //    {
            //        Timer.SetText(Convert.ToString(shiftsLeft));
            //        TimerProgress.fillAmount = (float)shiftsLeft / Level.Shifts;
            //    }
            //    else
            //    {
            //        State = GameState.Paused;
            //        CompleteGame();
            //    }
            //}
        }

        public void ShowDialog(TweenPanel dialog)
        {
            dialog.Show();
        }

        public void SetScoreDialog(bool completed)
        {
            ScoreDialogTitle.SetText(completed ? "Win" : "Time is up");
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