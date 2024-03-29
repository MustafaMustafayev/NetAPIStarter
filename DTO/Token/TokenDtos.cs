﻿using DTO.User;

namespace DTO.Token;

public record TokenToListDto()
{
    public Guid TokenId {  get; set; }
    public UserToListDto User {  get; set; }
    public string AccessToken { get; set; }
    public DateTimeOffset AccessTokenExpireDate { get; set; }
    public string RefreshToken { get; set; }
    public DateTimeOffset RefreshTokenExpireDate { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}