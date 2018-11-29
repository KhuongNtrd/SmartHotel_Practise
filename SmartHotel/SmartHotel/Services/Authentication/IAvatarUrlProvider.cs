namespace SmartHotel.Services.Authentication
{
    public interface IAvatarUrlProvider
    {
        string GetAvatarUrl(string email);
    }
}
