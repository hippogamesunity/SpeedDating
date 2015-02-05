namespace Assets.Scripts.Views
{
    public class Play : ViewBase
    {
        public TweenPanel PauseDialog;

        public void Start()
        {
            PauseDialog.Hide(0f);
        }

        public void ShowDialog()
        {
            PauseDialog.Show(TweenDirection.Right);
        }

        public void CloseDialog()
        {
            PauseDialog.Hide(TweenDirection.Right);
        }
    }
}