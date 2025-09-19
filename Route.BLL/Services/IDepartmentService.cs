using Route.BLL.DTOs;

namespace Route.BLL.Services
{
    public interface IDepartmentService
    {
        int AddDepartment(DepartmentCreationDTO deptDTO);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDTO> GetAllDepartments();
        DepartmentDetailsDTO? GetDepartmentById(int id);
        int UpdateDepartment(int id, DepartmentUpdateDTO deptDTO);
    }
}