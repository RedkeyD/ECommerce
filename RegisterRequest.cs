namespace ECommerce.Contracts.Authentication;

public record RegisterRequest(
    string Username,
    string Email, 
    string PasswordHash);