using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Temp.Message
{
    public class ReqMessage : RequestMessage<int>
    {
        public int Count { get; set; }
        public ReqMessage(int count)
        {
            Count = count;
        }
    }
}
