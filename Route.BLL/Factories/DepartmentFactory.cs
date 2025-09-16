using Route.BLL.DTOs;
using Route.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.BLL.Factories
{
    public static class DepartmentFactory
    {
        public static DepartmentDTO ToDepartmentsDTO(this Department d)
        {
            return new DepartmentDTO
            {
                DeptId = d.Id,
                Name = d.Name,
                Code = d.Code,
                Description = d.Description,
                DateOfCreation = d.CreatedOn
            };
        }

        public static DepartmentDetailsDTO ToDepartmentDetailsDTO(this Department department)
        {
            return new DepartmentDetailsDTO
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreatedBy = department.CreatedBy,
                CreatedOn = department.CreatedOn,
                LastModificationBy = department.LastModificationBy,
                LastModificationOn = department.LastModificationOn,
                IsDeleted = department.IsDeleted
            };
        }

        public static Department ToEntity(this DepartmentCreationDTO deptDTO)
        {
            return new Department
            {
                Name = deptDTO.Name,
                Code = deptDTO.Code,
                Description = deptDTO.Description,
                CreatedOn = deptDTO.CreatedOn,
            };
        }
        public static Department ToEntity(this DepartmentUpdateDTO deptDTO)
        {
            return new Department
            {
                Name = deptDTO.Name,
                Code = deptDTO.Code,
                Description = deptDTO.Description,
                CreatedOn = deptDTO.CreatedOn,
            };
        }

    }
}
