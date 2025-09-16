namespace Route.BLL.DTOs
{
    public class DepartmentUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
