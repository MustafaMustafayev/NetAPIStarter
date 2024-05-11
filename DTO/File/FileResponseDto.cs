﻿using CORE.Enums;

namespace DTO.File;

public record FileResponseDto
{
    public Guid Id { get; set; }
    public string OriginalName { get; set; }
    public string HashName { get; set; }
    public string Extension { get; set; }
    public double Length { get; set; }
    public string Path { get; set; }
    public EFileType Type { get; set; }
}