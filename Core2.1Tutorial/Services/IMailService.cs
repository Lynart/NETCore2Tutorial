namespace Core2._1Tutorial.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}