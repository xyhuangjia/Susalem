﻿using Volo.Abp.Application.Dtos;

namespace Susalem.Abp.Identity
{
    public class OrganizationUnitGetUnaddedRoleByPagedDto : PagedAndSortedResultRequestDto
    {

        public string Filter { get; set; }
    }
}