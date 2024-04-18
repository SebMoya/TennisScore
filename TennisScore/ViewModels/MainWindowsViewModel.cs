using System.ComponentModel;
using TennisScore.Manager;

namespace TennisScore.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private ScoreManager _scoreManager;

    public event PropertyChangedEventHandler PropertyChanged;

    public string Score => _scoreManager.GetScore();
    public string Player1Games => _scoreManager.Player1.WonGames.ToString();
    public string Player2Games => _scoreManager.Player2.WonGames.ToString();
    public string Player1Sets => _scoreManager.Player1.Set.ToString();
    public string Player2Sets => _scoreManager.Player2.Set.ToString();

    public MainWindowViewModel()
    {
        _scoreManager = new ScoreManager();
    }

    public void Player1Scored()
    {
        _scoreManager.Player1Scored();
        OnPropertyChanged(nameof(Score));
        OnPropertyChanged(nameof(Player1Games));
        OnPropertyChanged(nameof(Player2Games));
        OnPropertyChanged(nameof(Player1Sets));
        OnPropertyChanged(nameof(Player2Sets));
    }

    public void Player2Scored()
    {
        _scoreManager.Player2Scored();
        OnPropertyChanged(nameof(Score));
        OnPropertyChanged(nameof(Player1Games));
        OnPropertyChanged(nameof(Player2Games));
        OnPropertyChanged(nameof(Player1Sets));
        OnPropertyChanged(nameof(Player2Sets));
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}