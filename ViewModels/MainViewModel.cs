using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Temp.Message;

namespace Temp.ViewModels
{
    partial class MainViewModel : ObservableRecipient, IRecipient<MyMessage>
    {
        public MainViewModel()
        {
            IsActive = true;
        }

        string text = "Hello Count:";

        [ObservableProperty]
        string message;

        public void Receive(MyMessage message)
        {
            Message = text + message.Count;
        }
    }
}
