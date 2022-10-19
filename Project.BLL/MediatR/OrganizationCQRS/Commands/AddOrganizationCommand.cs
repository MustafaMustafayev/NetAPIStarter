﻿using MediatR;
using Project.DTO.Organization;
using Project.DTO.Responses;

namespace Project.BLL.MediatR.OrganizationCQRS.Commands;

public record AddOrganizationCommand
    (OrganizationToAddDto Organization) : IRequest<IResult>;