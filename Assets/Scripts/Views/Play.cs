using Assets.Scripts.Common;

namespace Assets.Scripts.Views
{
    public class Play : ViewBase
    {
        public TweenPanel PauseDialog;
        public TweenPanel ScoreDialog;
        public UILabel ScoreDialogTitle;
        public UILabel ScoreDialogMessage;

        protected override void Initialize()
        {
            PauseDialog.Hide(0f);
            ScoreDialog.Hide(0f);
        }

        protected override void Cleanup()
        {
            PauseDialog.Hide(0f);
            ScoreDialog.Hide(0f);
        }

        public void ShowPauseDialog()
        {
            PauseDialog.Show(TweenDirection.Right);
        }

        public void ClosePauseDialog()
        {
            PauseDialog.Hide(TweenDirection.Right);
        }

        public void ShowScoreDialog(bool completed)
        {
            ScoreDialogTitle.SetText(completed ? "Win" : "Time is up");
            ScoreDialogMessage.SetText(completed ? "Congratulation, level completed!" : "Better luck next time!");
            ScoreDialog.Show(TweenDirection.Right);
        }

        public void CloseScoreDialog()
        {
            ScoreDialog.Hide(TweenDirection.Right);
        }
    }
}