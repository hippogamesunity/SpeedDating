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
        public Transform HourHand;
        public UITexture TimeIcon;
        public UITexture SwapIcon;
        public GameObject RestartButton;
        public GameObject NextButton;

        protected override void Initialize()
        {
            PauseDialog.Hide(0f);
            ScoreDialog.Hide(0f);
            HelpDialog.Hide(0f);

            if (Engine.Level.Type == LevelType.Memo)
            {
                Score.SetText(null);
            }
            else
            {
                Score.SetText("0/{0}", Engine.Level.HideTarget ? "?" : Convert.ToString(Engine.Level.Target));
            }

            if (Engine.Level.Type == LevelType.Easy || Engine.Level.Type == LevelType.Hard)
            {
                TimeIcon.enabled = true;
                SwapIcon.enabled = false;
                HourHand.gameObject.SetActive(true);
                HelpDialogMessage.SetLocalizedText("%TimeMode%");
            }
            else if (Engine.Level.Type == LevelType.Swap)
            {
                SwapIcon.enabled = true;
                TimeIcon.enabled = false;
                HourHand.gameObject.SetActive(false);
                HelpDialogMessage.SetLocalizedText("%SwapMode%");
            }
            else if (Engine.Level.Type == LevelType.Memo)
            {
                TimeIcon.enabled = true;
                SwapIcon.enabled = false;
                HourHand.gameObject.SetActive(true);
                HelpDialogMessage.SetLocalizedText(Engine.Level.Memorize ? "%MemoMode1%" : "%MemoMode2%");
            }

            Background.mainTexture = Resources.Load<Texture2D>("Images/Background/" + GameData.GetBackground(Engine.Level));
        }

        protected override void Cleanup()
        {
            Initialize();
        }

        public void Update()
        {
            if (Engine.State != GameState.Playing) return;

            if (Engine.Level.Type == LevelType.Easy || Engine.Level.Type == LevelType.Hard || Engine.Level.Type == LevelType.Memo)
            {
                var timespan = Engine.Timeout - DateTime.Now;

                if (timespan.TotalSeconds > 0)
                {
                    if (Engine.State != GameState.Playing) return;

                    Timer.SetText(Convert.ToString(Math.Round(timespan.TotalSeconds)));

                    var p = (float) timespan.TotalSeconds / (Engine.Level.Memorize ? Engine.Level.MemoizeTime : Engine.Level.Time);

                    HourHand.rotation = Quaternion.Euler(0, 0, 360 * p - 360);

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
                    if (Engine.Level.Type == LevelType.Memo && Engine.Level.Memorize)
                    {
                        Get<Engine>().PlayMemo();
                    }
                    else
                    {
                        Get<Engine>().CompleteGame();
                    }
                }
            }
            else if (Engine.Level.Type == LevelType.Swap)
            {
                var swapsleft = Engine.Level.Swaps - Engine.Swaps;

                if (swapsleft >= 0)
                {
                    if (swapsleft == 1)
                    {
                        var blink = (Mathf.Sin(4 * Time.time) + 1) / 2;

                        Timer.color = new Color(1, blink, blink);
                    }
                    else
                    {
                        Timer.color = Color.white;
                    }

                    Timer.SetText(Convert.ToString(swapsleft));
                }
            }
        }

        public void ShowDialog(TweenPanel dialog)
        {
            dialog.Show();
        }

        public void SetScoreDialog(bool completed, int coins)
        {
            ScoreDialogTitle.SetLocalizedText(completed ? "%Win%" : Engine.Level.Type == LevelType.Easy ? "%TimeUp%" : "%GameOver%");
            RestartButton.SetActive(!completed);
            NextButton.SetActive(completed);

            if (completed)
            {
                ScoreDialogMessage.SetLocalizedText(coins > 0 ? "%LevelCompleted%" : "%LevelPassed%", coins, Characters.GetCoinsLocale(coins));
            }
            else
            {
                ScoreDialogMessage.SetLocalizedText("%LevelFailed%");
            }
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
            Score.SetText("{0}/{1}", Engine.CalcScore(), Engine.Level.HideTarget ? "?" : Convert.ToString(Engine.Level.Target));
        }
    }
}