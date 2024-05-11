﻿using DTO.File;

namespace DTO.Organization;

public record OrganizationResponseDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public string Address { get; set; }
    public OrganizationResponseDto Parent { get; set; }
    public string PhoneNumber { get; set; }
    public string Tin { get; set; }
    public string Email { get; set; }
    public string Rekvizit { get; set; }
    public FileResponseDto LogoFile { get; set; }
}