using System;
using Assets.Scripts.Common;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public partial class Engine
    {
        public static Level Level;
        public static int TaskId = 999;
        public static DateTime Timeout;
        public static TimeSpan Timeleft;
        public static int Swaps;

        private static GameState _state;

        public static GameState State
        {
            get { return _state; }
            set
            {
                _state = value;
                
                Time.timeScale = value == GameState.Paused ? 0 : 1;
                Find<AudioPlayer>().ScheduleFix();
            }
        }

        public void StartGame(bool restart = false)
        {
            Level.Restart = restart;

            TaskScheduler.Kill(TaskId++);

            State = GameState.Ready;

            var play = Get<Play>();

            play.Open(BeginGame);

            if ((Level.Type == LevelType.Easy || Level.Type == LevelType.Swap || Level.Type == LevelType.Memo) && Level.Progress == 0)
            {
                TaskScheduler.CreateTask(() => PauseGame(play.HelpDialog), TaskId, 1);
            }
        }

        public void RestartGame()
        {
            if (Level.Type == LevelType.Memo)
            {
                Level.Memorize = true;
            }

            StartGame(restart: true);
        }

        public void PlayNext()
        {
            if (Level.Type == LevelType.Easy && GameData.EasyLevels.IndexOf(Level) == 1)
            {
                var play = Get<Play>();

                if (play.ScoreDialog.Displayed)
                {
                    play.ScoreDialog.Hide(TweenDirection.Left);
                    play.ShowDialog(play.ShopTipDialog);
                    return;
                }
            }

            var levels = GameData.GetLevels(Level.Type);

            if (Level.Progress < levels.Count - 1)
            {
                var progress = Level.Progress + 1;

                switch (Level.Type)
                {
                    case LevelType.Easy:
                        PlayEasyLevel(progress);
                        break;
                    case LevelType.Hard:
                        PlayHardLevel(progress);
                        break;
                    case LevelType.Swap:
                        PlaySwapLevel(progress);
                        break;
                    case LevelType.Memo:
                        PlayMemoLevel(progress);
                        break;
                    default:
                        throw new Exception();
                }
            }
            else
            {
                ExitGame();
            }
        }

        public void PauseGame(TweenPanel dialog)
        {
            Timeleft = Timeout - DateTime.Now;
            Get<Play>().ShowDialog(dialog);
            State = GameState.Paused;
        }

        public void ResumeGame()
        {
            Timeout = DateTime.Now.Add(Timeleft);
            GetComponent<Play>().CloseDialog();
            State = GameState.Playing;
        }

        public void CompleteGame()
        {
            State = GameState.Ready;

            var score = CalcScore();
            var success = false;
            var coins = 0;

            if (Level.Type == LevelType.Easy)
            {
                if (score >= Level.Target)
                {
                    success = true;

                    if (Profile.ProgressEasy <= Level.Progress)
                    {
                        Profile.ProgressEasy++;
                        coins = Level.TableNumber;
                    }
                }
            }
            else if (Level.Type == LevelType.Hard)
            {
                if (score >= Level.Target)
                {
                    success = true;

                    if (Profile.ProgressHard <= Level.Progress)
                    {
                        Profile.ProgressHard++;
                        coins = Level.TableNumber;
                    }
                }
            }
            else if (Level.Type == LevelType.Swap)
            {
                if (score >= Level.Target)
                {
                    success = true;

                    if (Profile.ProgressSwap <= Level.Progress)
                    {
                        Profile.ProgressSwap++;
                        coins = Level.TableNumber;
                    }
                }
            }
            else if (Level.Type == LevelType.Memo)
            {
                if (Level.FormationHash == GetFormation())
                {
                    success = true;

                    if (Profile.ProgressMemo <= Level.Progress)
                    {
                        Profile.ProgressMemo++;
                        coins = Level.TableNumber;
                    }
                }
            }

            Profile.Coins += coins;

            var play = Get<Play>();

            play.SetScoreDialog(success, coins);
            play.ShowDialog(play.ScoreDialog);

            Debug.Log("Profile.ShowAdTime=" + Profile.ShowAdTime);
            Debug.Log("AdBuddizBinding.IsReadyToShowAd()=" + AdBuddizBinding.IsReadyToShowAd());

            if (DateTime.UtcNow > Profile.ShowAdTime.AddMinutes(5) && AdBuddizBinding.IsReadyToShowAd() && Profile.Deluxe)
            {
                Profile.ShowAdTime = DateTime.UtcNow;
                TaskScheduler.CreateTask(AdBuddizBinding.ShowAd, 1f);
            }
        }

        public void ExitGame()
        {
            if (State != GameState.Paused && State != GameState.Ready) return;

            TaskScheduler.Kill(TaskId);

            switch (Level.Type)
            {
                case LevelType.Easy:
                    Get<EasyLevels>().Open();
                    break;
                case LevelType.Hard:
                    Get<HardLevels>().Open();
                    break;
                case LevelType.Swap:
                    Get<SwapLevels>().Open();
                    break;
                case LevelType.Memo:
                    Get<MemoLevels>().Open();
                    break;
                default:
                    throw new Exception();
            }

            State = GameState.Ready;
        }

        public void PlayMemo()
        {
            Level.Memorize = false;
            StartGame(restart: true);
        }
    }
}