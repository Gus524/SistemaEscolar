namespace Application.Interfaces;

public interface IDbSeeder
{
    Task InitializeAsync();
    Task SeedUsersAsync();
}