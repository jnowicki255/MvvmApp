namespace MvvmApp.Models
{
    public class ApiResponse<T>
    {
        public ReponseInfo Info { get; set; }

        public T[] Results { get; set; }
    }
}
